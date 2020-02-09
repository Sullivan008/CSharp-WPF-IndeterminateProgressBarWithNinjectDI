using IndeterminateProgressBarWithNinjectDI.Modules.MainWindow.Interfaces;

namespace IndeterminateProgressBarWithNinjectDI.Modules.MainWindow.Services
{
    public class SearchLastNumberService : ISearchLastNumberService
    {
        public delegate void SearchLastNumberCompleteDelegate(int lastNumber);

        public event SearchLastNumberCompleteDelegate Complete;

        public void Search()
        {
            int lastNumber = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                lastNumber = i;
            }

            Complete?.Invoke(lastNumber);
        }
    }
}
