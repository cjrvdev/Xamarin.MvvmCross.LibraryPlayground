using Foundation;
using UIKit;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross;
using MvvmCross.ViewModels;

namespace Xamarin.MvvmCross.LibraryPlayground.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate
    {
        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Window = new UIWindow(UIScreen.MainScreen.Bounds);

            var setup = new Setup();
            setup.PlatformInitialize(this, Window);

            var startup = Mvx.Resolve<IMvxAppStart>();
            startup.Start();

            Window.MakeKeyAndVisible();

            return true;
        }
    }
}
