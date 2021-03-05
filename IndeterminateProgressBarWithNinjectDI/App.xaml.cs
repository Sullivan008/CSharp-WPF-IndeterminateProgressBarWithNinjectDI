using System.Windows;
using IndeterminateProgressBarWithNinjectDI.Container;
using IndeterminateProgressBarWithNinjectDI.Container.Ninject;
using IndeterminateProgressBarWithNinjectDI.Windows.Main;

namespace IndeterminateProgressBarWithNinjectDI
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Bootstrapper.Init();

            DependencyInjector.Retrieve<MainWindow>().Show();
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        { }
    }
}
