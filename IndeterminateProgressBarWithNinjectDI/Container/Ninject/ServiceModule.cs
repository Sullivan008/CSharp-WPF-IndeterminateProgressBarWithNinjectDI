using IndeterminateProgressBarWithNinjectDI.Modules.General.Interfaces;
using IndeterminateProgressBarWithNinjectDI.Modules.General.Services;
using IndeterminateProgressBarWithNinjectDI.Modules.MainWindow.Handlers;
using IndeterminateProgressBarWithNinjectDI.Modules.MainWindow.Interfaces;
using IndeterminateProgressBarWithNinjectDI.Modules.MainWindow.Services;
using Ninject.Modules;

namespace IndeterminateProgressBarWithNinjectDI.Container.Ninject
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMainWindowLogicHandler>().To<MainWindowLogicHandler>();
            Bind<ISearchLastNumberService>().To<SearchLastNumberService>();
            Bind<IProgressBarWindowService>().To<ProgressBarWindowService>();
        }
    }
}
