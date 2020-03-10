using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.MvvmCross.LibraryPlayground.Core.ViewModels
{
    public class LandingViewModel : BaseViewModel
    {
        private string _title = string.Empty;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            Title = "Welcome!";
        }
    }
}

