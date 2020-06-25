using System.Collections.Generic;
using System;

namespace MapT.Entities
{
    public class ProjectView
    {
        public string Label { get; set; }
        public bool Visible { get; set; }
        public bool CheckedTree { get; set; }
        public Connection Connection { get; set; }
        public List<QueryView> QueryViews { get; set; } = new List<QueryView>();
        public string IdTree { get; private set; }
        public string IdTypeObject { get; set; }
        public static int numIncClasse;

        public ProjectView() { }

        public ProjectView(string label, bool checkedTree)
        {
            Label = label;
            Visible = false;
            CheckedTree = checkedTree;

            numIncClasse++;
            Random randNum = new Random();
            IdTree = $"PjV{numIncClasse}-{randNum.Next()}";
            IdTypeObject = "ProjectView";
        }

        public void AddQueryView(QueryView queryView)
        {
            QueryViews.Add(queryView);
        }

        public void RemoveQueryView(QueryView queryView)
        {
            QueryViews.Remove(queryView);
        }

        public void AddConnection(Connection connection)
        {
            Connection = connection;
        }
    }
}
