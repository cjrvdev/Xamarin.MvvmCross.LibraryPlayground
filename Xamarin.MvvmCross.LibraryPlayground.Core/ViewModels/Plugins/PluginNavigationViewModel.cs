using System;
using System.Threading.Tasks;

namespace Xamarin.MvvmCross.LibraryPlayground.Core.ViewModels
{
    public class PluginNavigationViewModel : BaseViewModel
    {
        public PluginNavigationViewModel()
        {
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            DoneText = "Ayeee!";
        }

        #region Property DoneText

        string _doneText = string.Empty;
        public string DoneText
        {
            get { return _doneText; }
            set { SetProperty(ref _doneText, value); }
        }

        #endregion
    }
}
