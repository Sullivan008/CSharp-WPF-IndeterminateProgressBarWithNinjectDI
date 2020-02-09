using IndeterminateProgressBarWithNinjectDI.ViewModels.MainWindow;

namespace IndeterminateProgressBarWithNinjectDI.Modules.MainWindow.Interfaces
{
    public interface IMainWindowLogicHandler
    {
        MainWindowViewModel MainWindowViewModel { get; set; }

        void SearchLastNumber(MainWindowViewModel vm);
    }
}
