using System;
using System.Threading.Tasks;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Plugin.Messenger;

namespace Xamarin.MvvmCross.LibraryPlayground.Core.ViewModels
{
    public class PluginMessengerViewModel : BaseViewModel
    {
        protected readonly IMvxMessenger messenger;

        public PluginMessengerViewModel()
        {
            messenger = Mvx.IoCProvider.Resolve<IMvxMessenger>();
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            var counterSubToken = messenger.Subscribe<CounterMessage>(OnCounterMessageReceived);
        }

        private void OnCounterMessageReceived(CounterMessage obj)
        {
            Counter++;
        }

        #region Property Counter

        int _counter = 0;
        public int Counter
        {
            get { return _counter; }
            set
            {
                SetProperty(ref _counter, value);
                RaisePropertyChanged(nameof(CounterString));
            }
        }

        #endregion

        #region Property CounterString

        public string CounterString
        {
            get { return string.Format("{0} messages received", Counter); }
        }

        #endregion

        #region Command SendMessage

        IMvxCommand _sendMessageCommand;
        public IMvxCommand SendMessageCommand
        {
            get
            {
                return _sendMessageCommand ?? (_sendMessageCommand = new MvxCommand(
                    () => this.ExecuteSendMessageCommand()));
            }
        }

        void ExecuteSendMessageCommand()
        {
            var messenger = Mvx.IoCProvider.Resolve<IMvxMessenger>();
            messenger.Publish(new CounterMessage(this));
        }

        #endregion
    }

    public class CounterMessage : MvxMessage
    {
        public CounterMessage(object sender) : base(sender)
        {
        }
    }
}
