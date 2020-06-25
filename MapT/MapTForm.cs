using System.Windows.Forms;
using MapT.Entities;
using MapT.Services;
using MapWinGIS;

namespace MapT
{
    public partial class MapTForm : Form
    {
        ListLayerView listLayerView = new ListLayerView();
        bool loadingTreeView = false;

        public MapTForm()
        {
            InitializeComponent();
        }

        private void InstantiateObjects()
        {
            LayerView layerView_00 = new LayerView("Projetos", true);
            listLayerView.AddListView(layerView_00);

            Connection connection_00 = new Connection("postgres", "zaxscd098", "localhost", "loc2");

            // Proj0001
            QueryView queryView_00 = new QueryView
            {
                Label = "Talhões",
                IdLayer = 0,
                Query = "select st_buffer(geom, 0.01) AS buffer, * FROM talhao where id <= 40",
                Color = 250,
                CheckedTree = true
            };

            ProjectView projectView_00 = new ProjectView("proj0001", true);
            layerView_00.AddProjectView(projectView_00);
            projectView_00.AddConnection(connection_00);
            projectView_00.AddQueryView(queryView_00);

            // Proj0002
            QueryView queryView_01 = new QueryView
            {
                Label = "Talhões",
                IdLayer = 1,
                Query = "select st_buffer(geom, 0.01) AS buffer, * FROM talhao where id > 40",
                Color = 200,
                CheckedTree = true
            };

            ProjectView projectView_01 = new ProjectView("proj0002", true);
            layerView_00.AddProjectView(projectView_01);
            projectView_01.AddConnection(connection_00);
            projectView_01.AddQueryView(queryView_01);
        }

        private void CreatTreeView(ListLayerView listLayerView)
        {
            int nodeL = 0;
            foreach (LayerView layerview in listLayerView.LayerViews)
            {
                MaptTreeView.Nodes.Add(layerview.Label);
                MaptTreeView.Nodes[nodeL].Checked = true;
                MaptTreeView.Nodes[nodeL].Name = layerview.IdTree;

                if (layerview.ShowNodesProjectViews)
                {
                    int nodeP = 0;
                    foreach (ProjectView projectView in layerview.ProjectViews)
                    {
                        MaptTreeView.Nodes[nodeL].Nodes.Add(projectView.Label);
                        MaptTreeView.Nodes[nodeL].Nodes[nodeP].Checked = true;
                        MaptTreeView.Nodes[nodeL].Nodes[nodeP].Name = projectView.IdTree;

                        var ds = new OgrDatasource();
                        ds.Open(projectView.Connection.StringConexao());

                        int nodeQ = 0;
                        foreach (QueryView queryView in projectView.QueryViews)
                        {
                            MaptTreeView.Nodes[nodeL].Nodes[nodeP].Nodes.Add(queryView.Label);
                            MaptTreeView.Nodes[nodeL].Nodes[nodeP].Nodes[nodeQ].Checked = true;
                            MaptTreeView.Nodes[nodeL].Nodes[nodeP].Nodes[nodeQ].Name = queryView.IdTree;

                            var buffer = ds.RunQuery(queryView.Query);
                            MapTAxMap.AddLayer(buffer, true);
                            buffer.GetBuffer().DefaultDrawingOptions.FillColor = queryView.Color;

                            nodeQ++;
                        }
                        nodeP++;

                        ds.Close();
                    }
                }
                nodeL++;
            }
            MaptTreeView.ExpandAll();
            MapTAxMap.ZoomToMaxVisibleExtents();
        }

        private void MapTTest_Click(object sender, System.EventArgs e)
        {
            InstantiateObjects();
            CreatTreeView(listLayerView);
        }

        private void MaptTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if ((e.Node.Name != "") && (!loadingTreeView))
            {
                string idTypeObject = "";
                foreach (LayerView layerview in listLayerView.LayerViews)
                {
                    if (layerview.IdTree == e.Node.Name)
                    {
                        idTypeObject = layerview.IdTypeObject;
                    }

                    foreach (ProjectView projectView in layerview.ProjectViews)
                    {
                        if (projectView.IdTree == e.Node.Name)
                        {
                            idTypeObject = projectView.IdTypeObject;
                        }

                        foreach (QueryView queryView in projectView.QueryViews)
                        {
                            if (queryView.IdTree == e.Node.Name)
                            {
                                idTypeObject = queryView.IdTypeObject;
                            }
                        }
                    }
                }

                MaintainConsistency.ConsistencyCheckedTree(idTypeObject, e.Node.Name, e.Node.Checked, listLayerView);
            }
        }

        private void LoadTreeView()
        {
            // Mantém a consistência dos nós no MapTTreeView
            loadingTreeView = true;
            foreach (TreeNode ly in MaptTreeView.Nodes)
            {
                ly.Checked = MaintainConsistency.StatusChecked(ly.Name, listLayerView);
                foreach (TreeNode pj in ly.Nodes)
                {
                    pj.Checked = MaintainConsistency.StatusChecked(pj.Name, listLayerView);
                    foreach (TreeNode qy in pj.Nodes)
                    {
                        qy.Checked = MaintainConsistency.StatusChecked(qy.Name, listLayerView);
                        
                        // Torna a layer invisível/visível
                        if (qy.Checked)
                        {
                            MapTAxMap.set_LayerVisible(MaintainConsistency.LoadIdLayer(qy.Name, listLayerView), true);
                        }
                        else
                        {
                            MapTAxMap.set_LayerVisible(MaintainConsistency.LoadIdLayer(qy.Name, listLayerView), false);
                        }
                    }
                }
            }
            loadingTreeView = false;
        }

        private void MaptTreeView_Click(object sender, System.EventArgs e)
        {
            LoadTreeView();
        }
    }
}