
using Android.Views;
using AndroidX.RecyclerView.Widget;

namespace BubbleTabs.Adapters
{
    public class RecyclerAdapterViewHolder : RecyclerView.ViewHolder
    {
        public View Cell { get; set; }


        public RecyclerAdapterViewHolder(View c) : base(c)
        {
            Cell = c;
        }
    }
}