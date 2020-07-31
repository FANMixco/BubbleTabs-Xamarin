using Android.Views;
using AndroidX.RecyclerView.Widget;

namespace BubbleTabs.Adapters
{
    class RecyclerAdapter : RecyclerView.Adapter
    {
        public override int ItemCount => 20;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View cell = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.bubbletab_cell, parent, false);
            return new RecyclerAdapterViewHolder(cell);
        }
    }
}