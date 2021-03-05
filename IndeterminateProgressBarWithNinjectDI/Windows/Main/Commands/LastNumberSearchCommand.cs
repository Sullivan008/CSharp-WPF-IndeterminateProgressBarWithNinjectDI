using System.Threading.Tasks;
using System.Windows.Input;
using IndeterminateProgressBarWithNinjectDI.Core.Commands;

namespace IndeterminateProgressBarWithNinjectDI.Windows.Main.ViewModels
{
    public partial class MainWindowViewModel
    {
        private ICommand _lastNumberSearchCommand;
        public ICommand LastNumberSearchCommand =>
            _lastNumberSearchCommand ?? (_lastNumberSearchCommand = new RelayCommandAsync(ExecuteLastNumberSearchCommand));

        private async Task ExecuteLastNumberSearchCommand()
        {
            ProcessResult = "The process has begun";
            _progressWindowService.ShowProgressWindow();

            int lastNumber = await Task.Run(() => _searchLastNumberService.Search());

            _progressWindowService.CloseProgressWindow();
            ProcessResult = $"Last number of the FOR loop: {lastNumber}";
        }
    }
}
