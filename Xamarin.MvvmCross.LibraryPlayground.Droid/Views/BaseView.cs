using Android.OS;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Xamarin.MvvmCross.LibraryPlayground.Droid.Views
{
    public abstract class BaseView : BaseActivity
    {
        protected Toolbar Toolbar { get; set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(LayoutResource);
        }
    }
}
