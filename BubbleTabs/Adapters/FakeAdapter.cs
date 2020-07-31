using AndroidX.Fragment.App;
using BubbleTabs.Fragments;

namespace BubbleTabs.Adapters
{
    class FakeAdapter : FragmentStatePagerAdapter
    {
        public FakeAdapter(FragmentManager fm, int behavior) : base(fm, behavior)
        {
        }

        public override int Count => 5;

        public override Fragment GetItem(int position)
        {
            switch (position)
            {
                default:
                    return FakeFragment.NewInstance();
            }
        }
    }
}