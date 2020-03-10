using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.ViewModels;

namespace Xamarin.MvvmCross.LibraryPlayground.Droid
{
    public class Setup : MvxAppCompatSetup
    {
        public Setup() : base()
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}
