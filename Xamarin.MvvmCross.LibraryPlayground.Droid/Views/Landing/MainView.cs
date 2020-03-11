
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.Widget;
using Xamarin.MvvmCross.LibraryPlayground.Core.ViewModels;

namespace Xamarin.MvvmCross.LibraryPlayground.Droid.Views
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait,
              LaunchMode = LaunchMode.SingleTask)]
    public class MainView : BaseActivity<MainViewModel>
    {
        protected override int LayoutResource => Resource.Layout.main_activity;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            if (toolbar != null)
            {
                SetSupportActionBar(toolbar);
                // Hide back button
                SupportActionBar.SetDisplayHomeAsUpEnabled(false);
                SupportActionBar.SetHomeButtonEnabled(true);
            }
        }
    }
}