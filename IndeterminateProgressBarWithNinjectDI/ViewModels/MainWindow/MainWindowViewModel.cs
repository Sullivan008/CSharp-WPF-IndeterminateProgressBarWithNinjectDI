using IndeterminateProgressBarWithNinjectDI.Command;
using IndeterminateProgressBarWithNinjectDI.Modules.MainWindow.Interfaces;
using System;
using System.Windows.Input;

namespace IndeterminateProgressBarWithNinjectDI.ViewModels.MainWindow
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _processStatus;

        private IMainWindowLogicHandler _mainWindowLogicHandler;

        public MainWindowViewModel(IMainWindowLogicHandler mainWindowLogicHandler)
        {
            _mainWindowLogicHandler = mainWindowLogicHandler ?? throw new ArgumentNullException(nameof(mainWindowLogicHandler));
            _mainWindowLogicHandler.MainWindowViewModel = this;

            ProcessStatus = "The process has not started yet.";
        }

        #region PROPERTIES Getters/ Setters

        public string ProcessStatus
        {
            get => _processStatus;
            set
            {
                _processStatus = value;
                OnPropertyChanged("ProcessStatus");
            }
        }

        #endregion

        #region COMMANDS

        public ICommand StartBtnClick =>
            new DelegateCommand(SearchLastNumber);

        #endregion

        #region PRIVATE COMMAND Helper Methods

        private void SearchLastNumber()
        {
            _mainWindowLogicHandler.SearchLastNumber(this);
        }

        #endregion
    }
}
