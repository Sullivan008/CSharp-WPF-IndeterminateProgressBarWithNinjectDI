using IndeterminateProgressBarWithNinjectDI.Modules.General.Interfaces;
using IndeterminateProgressBarWithNinjectDI.Modules.MainWindow.Interfaces;
using IndeterminateProgressBarWithNinjectDI.ViewModels.MainWindow;
using System;
using System.Threading;

namespace IndeterminateProgressBarWithNinjectDI.Modules.MainWindow.Handlers
{
    public class MainWindowLogicHandler : IMainWindowLogicHandler
    {
        private readonly IProgressBarWindowService _progressBarWindowService;

        private readonly ISearchLastNumberService _searchLastNumberService;

        public MainWindowViewModel MainWindowViewModel { get; set; }

        public MainWindowLogicHandler(IProgressBarWindowService progressBarWindowService, ISearchLastNumberService searchLastNumberService)
        {
            _progressBarWindowService =
                progressBarWindowService ?? throw new ArgumentNullException(nameof(progressBarWindowService));
            _searchLastNumberService =
                searchLastNumberService ?? throw new ArgumentNullException(nameof(searchLastNumberService));
        }

        public void SearchLastNumber(MainWindowViewModel vm)
        {
            _progressBarWindowService.ShowProgressBarWindow();

            _searchLastNumberService.Complete += Complete;

            new Thread(_searchLastNumberService.Search).Start();
        }

        #region PRIVATE Helper Methods

        private void Complete(int lastNumber)
        {
            _progressBarWindowService.CloseProgressBarWindow();

            MainWindowViewModel.ProcessStatus = $"Last number of the FOR loop: {lastNumber}";
        }

        #endregion
    }
}
