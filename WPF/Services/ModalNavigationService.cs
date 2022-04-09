using WPF.Stores;
using WPF.ViewModel;
using System;
using System.Diagnostics.Contracts;

namespace WPF.Services
{
    public class ModalNavigationService<viewModelBase> : INavigationService 
        where viewModelBase : ViewModelBase
    {
        private readonly ModalNavigationStore _navigationStore;
        private readonly Func<viewModelBase> _createViewModel;

        public ModalNavigationService( ModalNavigationStore navigationStore, Func<viewModelBase> createViewModel )
        {
            Contract.Requires(navigationStore != null && createViewModel != null);
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate(object parameter = null)
        {
            _navigationStore.currentViewModel = _createViewModel();
        }
    }
}
