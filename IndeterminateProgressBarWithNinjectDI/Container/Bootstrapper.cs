using IndeterminateProgressBarWithNinjectDI.Container.Ninject;
using IndeterminateProgressBarWithNinjectDI.Container.Ninject.Modules.Windows;

namespace IndeterminateProgressBarWithNinjectDI.Container
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.LoadModules(new MainWindowModule(), new ProgressWindowModule());
        }
    }
}
