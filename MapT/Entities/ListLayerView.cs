using System.Collections.Generic;

namespace MapT.Entities
{
    public class ListLayerView
    {
        public List<LayerView> LayerViews { get; set; } = new List<LayerView>();

        public void AddListView(LayerView layerView)
        {
            LayerViews.Add(layerView);
        }

        public void RemoveListView(LayerView layerView)
        {
            LayerViews.Remove(layerView);
        }
    }
}
