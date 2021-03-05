using IndeterminateProgressBarWithNinjectDI.Windows.Main.Services.Search;
using IndeterminateProgressBarWithNinjectDI.Windows.Main.Services.Search.Interfaces;
using IndeterminateProgressBarWithNinjectDI.Windows.Main.ViewModels;
using IndeterminateProgressBarWithNinjectDI.Windows.Main.ViewModels.Interfaces;
using Ninject.Modules;

namespace IndeterminateProgressBarWithNinjectDI.Container.Ninject.Modules.Windows
{
    public class MainWindowModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMainWindowViewModel>().To<MainWindowViewModel>().InTransientScope();
            Bind<ISearchLastNumberService>().To<SearchLastNumberService>().InTransientScope();
        }
    }
}
