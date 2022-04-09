using System;
using WPF.Stores;
using System.Diagnostics.Contracts;
using WPF.ViewModel;

namespace WPF.Services
{
    public class ParameterNavigationService<parameter, viewModelBase> : INavigationService 
        where viewModelBase : ViewModelBase 
    {
        private readonly ModalNavigationStore _navigationStore;
        private readonly Func<parameter, viewModelBase> _createViewModel;

        public ParameterNavigationService
        ( 
            ModalNavigationStore navigationStore, 
            Func<parameter, viewModelBase> createViewModel
        )
        {
            Contract.Requires(navigationStore != null && createViewModel != null);
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate( object parameter )
        {
            _navigationStore.currentViewModel = _createViewModel((parameter)parameter);
        }
    }
}