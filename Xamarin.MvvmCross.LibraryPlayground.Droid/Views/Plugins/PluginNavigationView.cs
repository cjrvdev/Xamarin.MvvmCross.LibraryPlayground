using System;
using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using Xamarin.MvvmCross.LibraryPlayground.Core.ViewModels;

namespace Xamarin.MvvmCross.LibraryPlayground.Droid.Views
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.fragment_container, true)]
    [Register("Xamarin.MvvmCross.LibraryPlayground.Droid.Views.PluginNavigationView")]
    public class PluginNavigationView : BaseFragment<PluginNavigationViewModel>
    {
        protected override int FragmentId => Resource.Layout.plugin_navigation_fragment;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            // Lookup views here

            return view;
        }
    }
}
