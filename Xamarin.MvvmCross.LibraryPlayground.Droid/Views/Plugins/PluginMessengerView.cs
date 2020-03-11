using System;
using Android.Runtime;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using Xamarin.MvvmCross.LibraryPlayground.Core.ViewModels;

namespace Xamarin.MvvmCross.LibraryPlayground.Droid.Views
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.fragment_container, true)]
    [Register("Xamarin.MvvmCross.LibraryPlayground.Droid.Views.PluginMessengerView")]
    public class PluginMessengerView : BaseFragment<PluginMessengerViewModel>
    {
        protected override int FragmentId => Resource.Layout.plugin_messenger_fragment;
    }
}
