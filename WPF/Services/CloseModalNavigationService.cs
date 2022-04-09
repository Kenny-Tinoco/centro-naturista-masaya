using WPF.Stores;
using System.Diagnostics.Contracts;

namespace WPF.Services
{
    public class CloseModalNavigationService : INavigationService
    {
        private readonly ModalNavigationStore _navigationStore;

        public CloseModalNavigationService( ModalNavigationStore navigationStore )
        {
            Contract.Requires(navigationStore != null);
            _navigationStore = navigationStore;
        }

        public void Navigate(object parameter = null)
        {
            _navigationStore.Close();
        }
    }
}
