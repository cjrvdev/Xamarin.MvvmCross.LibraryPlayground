using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Xamarin.MvvmCross.LibraryPlayground.Core.ViewModels;

namespace Xamarin.MvvmCross.LibraryPlayground.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Manager")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FirstViewModel>();
        }
    }
}
