using MvvmCross.Platforms.Ios.Core;
using MvvmCross.ViewModels;

namespace Xamarin.MvvmCross.LibraryPlayground.iOS
{
    public class Setup : MvxIosSetup
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
