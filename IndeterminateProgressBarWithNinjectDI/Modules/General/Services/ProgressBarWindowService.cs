using IndeterminateProgressBarWithNinjectDI.Modules.General.Interfaces;
using IndeterminateProgressBarWithNinjectDI.Windows;
using System;

namespace IndeterminateProgressBarWithNinjectDI.Modules.General.Services
{
    public class ProgressBarWindowService : IProgressBarWindowService
    {
        private readonly ProgressWindow _progressWindow;

        public ProgressBarWindowService(ProgressWindow progressWindow)
        {
            _progressWindow = progressWindow ?? throw new ArgumentNullException(nameof(progressWindow));
        }

        public void ShowProgressBarWindow()
        {
            _progressWindow.Show();
        }

        public void CloseProgressBarWindow()
        {
            _progressWindow.Dispatcher?.Invoke(System.Windows.Threading.DispatcherPriority.Normal,
                new Action(delegate
                {
                    _progressWindow.Close();
                }));
        }
    }
}
