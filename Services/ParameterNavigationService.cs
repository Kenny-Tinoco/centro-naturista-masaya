using System;
using MasayaNaturistCenter.Stores;
using System.Diagnostics.Contracts;
using MasayaNaturistCenter.ViewModel;

namespace MasayaNaturistCenter.Services
{
    public class ParameterNavigationService<parameter, viewModelBase> where viewModelBase : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<parameter, viewModelBase> _createViewModel;

        public ParameterNavigationService
        ( 
            NavigationStore navigationStore, 
            Func<parameter, viewModelBase> createViewModel 
        )
        {
            Contract.Requires(navigationStore != null && createViewModel != null);
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate(parameter parameter)
        {
            _navigationStore.currentViewModel = _createViewModel(parameter);
        }
    }
}