using IndeterminateProgressBarWithNinjectDI.Modules.MainWindow.Services;

namespace IndeterminateProgressBarWithNinjectDI.Modules.MainWindow.Interfaces
{
    public interface ISearchLastNumberService
    {
        event SearchLastNumberService.SearchLastNumberCompleteDelegate Complete;

        void Search();
    }
}
