using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Views;

namespace Xamarin.MvvmCross.LibraryPlayground.Droid
{
    [Activity(
        Label = "Xamarin.MvvmCross.LibraryPlayground"
        , MainLauncher = true
        , Icon = "@mipmap/ic_launcher"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenAppCompatActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

    }
}
