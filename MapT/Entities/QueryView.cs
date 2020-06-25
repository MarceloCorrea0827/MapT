using System;

namespace MapT.Entities
{
    public class QueryView
    {
        public string Label { get; set; }
        public int IdLayer { get; set; }
        public string Query { get; set; }
        public bool CheckedTree { get; set; }
        public uint Color { get; set; }
        public string IdTree { get; private set; }
        public string IdTypeObject { get; set; }
        private static int numIncClasse;

        public QueryView()
        {
            numIncClasse++;
            Random randNum = new Random();
            IdTree = $"QyV{numIncClasse}-{randNum.Next()}";
            IdTypeObject = "QueryView";
        }

        public QueryView(string label, int idLayer, string query, uint color, bool checkedTree)
        {
            Label = label;
            IdLayer = idLayer;
            Query = query;
            Color = color;
            CheckedTree = checkedTree;
        }
    }
}
