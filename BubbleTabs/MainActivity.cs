using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using AndroidX.ViewPager2.Widget;
using BubbleTabs.Adapters;
using Com.Github.Florent37.Bubbletab;

namespace BubbleTabs
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.bubbletab_activity_main);

            var bubbleTab = FindViewById<BubbleTab>(Resource.Id.bubbleTab);
            var viewPager = FindViewById<ViewPager2>(Resource.Id.viewPager);

            viewPager.Adapter = new FakeAdapter(this);

            bubbleTab.SetupWithViewPager(viewPager);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}