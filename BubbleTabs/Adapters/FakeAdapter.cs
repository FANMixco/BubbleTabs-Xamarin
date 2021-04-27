using AndroidX.Fragment.App;
using AndroidX.ViewPager2.Adapter;
using BubbleTabs.Fragments;

namespace BubbleTabs.Adapters
{
    class FakeAdapter : FragmentStateAdapter
    {
        public FakeAdapter(FragmentActivity fragmentActivity) : base(fragmentActivity)
        {
        }

        public override int ItemCount => 5;

        public override Fragment CreateFragment(int p0)
        {
            switch (p0)
            {
                default:
                    return FakeFragment.NewInstance();
            }
        }
    }
}