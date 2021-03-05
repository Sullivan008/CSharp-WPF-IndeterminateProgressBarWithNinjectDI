using IndeterminateProgressBarWithNinjectDI.Windows.Progress.Services;
using IndeterminateProgressBarWithNinjectDI.Windows.Progress.Services.Interfaces;
using IndeterminateProgressBarWithNinjectDI.Windows.Progress.ViewModels;
using IndeterminateProgressBarWithNinjectDI.Windows.Progress.ViewModels.Interfaces;
using Ninject.Modules;

namespace IndeterminateProgressBarWithNinjectDI.Container.Ninject.Modules.Windows
{
    public class ProgressWindowModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProgressWindowViewModel>().To<ProgressWindowViewModel>().InTransientScope();
            Bind<IProgressWindowService>().To<ProgressWindowService>().InSingletonScope();
        }
    }
}
