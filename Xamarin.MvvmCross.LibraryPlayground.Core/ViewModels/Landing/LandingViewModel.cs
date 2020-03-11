using System;
using System.Threading.Tasks;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace Xamarin.MvvmCross.LibraryPlayground.Core.ViewModels
{
    public class LandingViewModel : BaseViewModel
    {
        public override async Task Initialize()
        {
            await base.Initialize();
        }

        #region Command PluginNavigationSelected

        IMvxAsyncCommand _pluginNavigationSelectedCommand;
        public IMvxAsyncCommand PluginNavigationSelectedCommand
        {
            get
            {
                return _pluginNavigationSelectedCommand ?? (_pluginNavigationSelectedCommand = new MvxAsyncCommand(
                    async () => await this.ExecutePluginNavigationSelectedCommand()));
            }
        }

        async Task ExecutePluginNavigationSelectedCommand()
        {
            var navService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();
            await navService.Navigate<PluginNavigationViewModel>();
        }

        #endregion
    }
}
