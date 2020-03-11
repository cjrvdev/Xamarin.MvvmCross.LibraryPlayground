using System;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.ViewModels;
using Xamarin.MvvmCross.LibraryPlayground.Core.ViewModels;

namespace Xamarin.MvvmCross.LibraryPlayground.Droid.Views
{
    public abstract class BaseFragment : MvxFragment
    {
        protected abstract int FragmentId { get; }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(FragmentId, null);
        }
    }

    public abstract class BaseFragment<TViewModel> : BaseFragment where TViewModel : BaseViewModel
    {
        public new TViewModel ViewModel
        {
            get { return (TViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }
    }
}
