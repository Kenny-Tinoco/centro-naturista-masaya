using MasayaNaturistCenter.Stores;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Services
{
    public class CloseModalNavigationService : INavigationService
    {
        private readonly ModalNavigationStore _navigationStore;

        public CloseModalNavigationService( ModalNavigationStore navigationStore )
        {
            Contract.Requires(navigationStore != null);
            _navigationStore = navigationStore;
        }

        public void Navigate()
        {
            _navigationStore.Close();
        }
    }
}
