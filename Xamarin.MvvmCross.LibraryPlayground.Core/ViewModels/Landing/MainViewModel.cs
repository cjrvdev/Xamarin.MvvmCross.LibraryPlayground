using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace Xamarin.MvvmCross.LibraryPlayground.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
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

