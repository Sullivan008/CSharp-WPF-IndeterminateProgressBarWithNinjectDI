using IndeterminateProgressBarWithNinjectDI.Windows.Main.Services.Search.Interfaces;

namespace IndeterminateProgressBarWithNinjectDI.Windows.Main.Services.Search
{
    public class SearchLastNumberService : ISearchLastNumberService
    {
        public int Search()
        {
            int result = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                result = i;
            }

            return result;
        }
    }
}
