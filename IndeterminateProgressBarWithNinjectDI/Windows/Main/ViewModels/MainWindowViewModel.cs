using IndeterminateProgressBarWithNinjectDI.Core.ViewModels;
using IndeterminateProgressBarWithNinjectDI.Windows.Main.Services.Search.Interfaces;
using IndeterminateProgressBarWithNinjectDI.Windows.Main.ViewModels.Interfaces;
using IndeterminateProgressBarWithNinjectDI.Windows.Progress.Services.Interfaces;

namespace IndeterminateProgressBarWithNinjectDI.Windows.Main.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
    {
        private readonly IProgressWindowService _progressWindowService;

        private readonly ISearchLastNumberService _searchLastNumberService;

        public MainWindowViewModel(IProgressWindowService progressWindowService, ISearchLastNumberService searchLastNumberService)
        {
            _progressWindowService = progressWindowService;
            _searchLastNumberService = searchLastNumberService;
        }

        #region PROPERTIES GETTERS/ SETTERS

        private string _processResult = "The process has not started yet.";

        public string ProcessResult
        {
            get => _processResult;
            set
            {
                _processResult = value;

                OnPropertyChanged();
            }
        }

        #endregion
    }
}
