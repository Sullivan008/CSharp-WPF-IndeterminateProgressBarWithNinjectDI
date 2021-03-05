using System;
using IndeterminateProgressBarWithNinjectDI.Container.Ninject;
using IndeterminateProgressBarWithNinjectDI.Windows.Progress.Services.Interfaces;

namespace IndeterminateProgressBarWithNinjectDI.Windows.Progress.Services
{
    public class ProgressWindowService : IProgressWindowService
    {
        private ProgressWindow _progressWindow;

        public void ShowProgressWindow()
        {
            _progressWindow = DependencyInjector.Retrieve<ProgressWindow>();
            
            _progressWindow.Show();
        }

        public void CloseProgressWindow()
        {
            if (_progressWindow == null)
            {
                throw new ArgumentNullException(nameof(_progressWindow), @"The value cannot be null!");
            }

            _progressWindow.Close();
            _progressWindow = null;
        }
    }
}
