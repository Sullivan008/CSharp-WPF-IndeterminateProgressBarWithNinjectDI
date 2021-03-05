using IndeterminateProgressBarWithNinjectDI.Windows.Progress.ViewModels.Interfaces;

namespace IndeterminateProgressBarWithNinjectDI.Windows.Progress
{
    public partial class ProgressWindow
    {
        public ProgressWindow(IProgressWindowViewModel progressWindowViewModel)
        {
            InitializeComponent();

            DataContext = progressWindowViewModel;
        }
    }
}
