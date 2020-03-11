using System;
using System.Threading.Tasks;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace Xamarin.MvvmCross.LibraryPlayground.Core.ViewModels
{
    public class LandingViewModel : BaseViewModel
    {
        protected readonly IMvxNavigationService navigationService;

        public LandingViewModel()
        {
            navigationService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();
        }

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
            await navigationService.Navigate<PluginNavigationViewModel>();
        }

        #endregion

        #region Command PluginMessengerSelected

        IMvxAsyncCommand _pluginMessengerSelectedCommand;
        public IMvxAsyncCommand PluginMessengerSelectedCommand
        {
            get
            {
                return _pluginMessengerSelectedCommand ?? (_pluginMessengerSelectedCommand = new MvxAsyncCommand(
                    async () => await this.ExecutePluginMessengerSelectedCommand()));
            }
        }

        async Task ExecutePluginMessengerSelectedCommand()
        {
            await navigationService.Navigate<PluginMessengerViewModel>();
        }

        #endregion
    }
}
