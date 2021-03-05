using IndeterminateProgressBarWithNinjectDI.Windows.Main.ViewModels.Interfaces;

namespace IndeterminateProgressBarWithNinjectDI.Windows.Main
{
    public partial class MainWindow
    {
        public MainWindow(IMainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();

            DataContext = mainWindowViewModel;
        }
    }
}
