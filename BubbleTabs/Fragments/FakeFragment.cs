using Android.OS;
using Android.Views;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using BubbleTabs.Adapters;

namespace BubbleTabs.Fragments
{
    class FakeFragment : Fragment
    {
        RecyclerView RecyclerView { get; set; }

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			return inflater.Inflate(Resource.Layout.bubbletab_page, container, false);
		}

		public override void OnViewCreated(View view, Bundle savedInstanceState)
		{
			RecyclerView = view.FindViewById<RecyclerView>(Resource.Id.recyclerView);
			RecyclerView.SetLayoutManager(new GridLayoutManager(Context, 2));
			RecyclerView.SetAdapter(new RecyclerAdapter());
		}

		public static Fragment NewInstance()
		{
			return new FakeFragment();
		}
	}
}