using MapT.Entities;
using System.Windows.Forms;

namespace MapT.Services
{
    public class MaintainConsistency
    {
        public static void ConsistencyCheckedTree(string idTypeObject, string idTree, bool checkedTree, ListLayerView listLayerView)
        {
            // Se o objeto alterado for uma LayerView
            if (idTypeObject == "LayerView")
            {
                foreach (LayerView layerview in listLayerView.LayerViews)
                {
                    if (layerview.IdTree == idTree)
                    {
                        layerview.CheckedTree = checkedTree;
                    }
                    foreach (ProjectView projectView in layerview.ProjectViews)
                    {
                        projectView.CheckedTree = layerview.CheckedTree;

                        foreach (QueryView queryView in projectView.QueryViews)
                        {
                            queryView.CheckedTree = checkedTree;
                        }
                    }
                }
            }
            else
            {
                if (idTypeObject == "ProjectView")
                {
                    foreach (LayerView layerview in listLayerView.LayerViews)
                    {
                        foreach (ProjectView projectView in layerview.ProjectViews)
                        {
                            if (projectView.IdTree == idTree)
                            {
                                projectView.CheckedTree = checkedTree;

                                foreach (QueryView queryView in projectView.QueryViews)
                                {
                                    queryView.CheckedTree = projectView.CheckedTree;
                                }
                            }
                        }
                    }
                }

                if (idTypeObject == "QueryView")
                {
                    // Apenas altera o atributo CheckedTree das QueryViews
                    foreach (LayerView layerview in listLayerView.LayerViews)
                    {
                        foreach (ProjectView projectView in layerview.ProjectViews)
                        {
                            foreach (QueryView queryView in projectView.QueryViews)
                            {
                                if (queryView.IdTree == idTree)
                                {
                                    queryView.CheckedTree = checkedTree;
                                }
                            }
                        }
                    }
                }

                // Mantém a consistência dos nós-pais
                foreach (LayerView layerview in listLayerView.LayerViews)
                {
                    bool projAllCkecked = false;
                    foreach (ProjectView projectView in layerview.ProjectViews)
                    {
                        bool qryAllChecked = false;
                        foreach (QueryView queryView in projectView.QueryViews)
                        {
                            if (queryView.CheckedTree)
                            {
                                qryAllChecked = true;
                            }
                        }

                        if (!qryAllChecked)
                        {
                            projectView.CheckedTree = false;
                        }
                        else
                        {
                            projectView.CheckedTree = true;
                        }

                        if (projectView.CheckedTree)
                        {
                            projAllCkecked = true;
                        }
                    }

                    if (!projAllCkecked)
                    {
                        layerview.CheckedTree = false;
                    }
                    else
                    {
                        layerview.CheckedTree = true;
                    }
                }
            }
        }

        public static bool StatusChecked(string idTree, ListLayerView listLayerView)
        {
            bool bStatusChecked = false;

            foreach (LayerView layerview in listLayerView.LayerViews)
            {
                if (layerview.IdTree == idTree)
                {
                    bStatusChecked = layerview.CheckedTree;
                }
                foreach (ProjectView projectView in layerview.ProjectViews)
                {
                    if (projectView.IdTree == idTree)
                    {
                        bStatusChecked = projectView.CheckedTree;
                    }

                    foreach (QueryView queryView in projectView.QueryViews)
                    {
                        if (queryView.IdTree == idTree)
                        {
                            bStatusChecked = queryView.CheckedTree;
                        }
                    }
                }
            }
            return bStatusChecked;
        }

        public static int LoadIdLayer(string idTree, ListLayerView listLayerView)
        {
            int idLayer = -1;

            foreach (LayerView layerview in listLayerView.LayerViews)
            {
                foreach (ProjectView projectView in layerview.ProjectViews)
                {
                    foreach (QueryView queryView in projectView.QueryViews)
                    {
                        if (queryView.IdTree == idTree)
                        {
                            idLayer = queryView.IdLayer;
                        }
                    }
                }
            }
            return idLayer;
        }
    }
}