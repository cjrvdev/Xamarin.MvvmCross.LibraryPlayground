using System;
using Android.Runtime;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using Xamarin.MvvmCross.LibraryPlayground.Core.ViewModels;

namespace Xamarin.MvvmCross.LibraryPlayground.Droid.Views
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.fragment_container, false)]
    [Register("Xamarin.MvvmCross.LibraryPlayground.Droid.Views.LandingView")]
    public class LandingView : BaseFragment<LandingViewModel>
    {
        protected override int FragmentId => Resource.Layout.landing_fragment;
    }
}
