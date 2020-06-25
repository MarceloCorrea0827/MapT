using System.Collections.Generic;
using System;

namespace MapT.Entities
{
    public class LayerView
    {
        public string Label { get; set; }
        public bool CheckedTree { get; set; }
        public bool ShowNodesProjectViews { get; set; }
        public List<ProjectView> ProjectViews { get; set; } = new List<ProjectView>();
        public string IdTree { get; private set; }
        public string IdTypeObject { get; set; }
        private static int numIncClasse;

        public LayerView() { }

        public LayerView(string label, bool checkedTree)
        {
            Label = label;
            CheckedTree = checkedTree;
            ShowNodesProjectViews = true;

            numIncClasse++;
            Random randNum = new Random();
            IdTree = $"LyV{numIncClasse}-{randNum.Next()}";
            IdTypeObject = "LayerView";
        }

        public void AddProjectView(ProjectView projectView)
        {
            ProjectViews.Add(projectView);
        }

        public void RemoveProjectView(ProjectView projectView)
        {
            ProjectViews.Remove(projectView);
        }
    }
}
