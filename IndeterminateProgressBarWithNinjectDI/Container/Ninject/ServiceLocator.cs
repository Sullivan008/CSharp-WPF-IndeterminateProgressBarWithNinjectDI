using IndeterminateProgressBarWithNinjectDI.ViewModels.MainWindow;
using Ninject;

namespace IndeterminateProgressBarWithNinjectDI.Container.Ninject
{
    public class ServiceLocator
    {
        private readonly IKernel _kernel;

        public ServiceLocator()
        {
            _kernel = new StandardKernel(new ServiceModule());
        }

        public MainWindowViewModel MainWindowViewModel => _kernel.Get<MainWindowViewModel>();
    }
}
