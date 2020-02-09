using System.ComponentModel;
using System.Windows;

namespace IndeterminateProgressBarWithNinjectDI.Windows
{
    public partial class ProgressWindow : Window
    {
        public ProgressWindow()
        {
            InitializeComponent();
        }

        #region EVENTS

        private void ProgressWindow_OnClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Visibility = Visibility.Hidden;
        }

        #endregion
    }
}
