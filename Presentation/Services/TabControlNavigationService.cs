using MasayaNaturistCenter.Stores;
using MasayaNaturistCenter.ViewModel;
using MasayaNaturistCenter.ViewModel.Components;
using System;

namespace MasayaNaturistCenter.Services
{
    public class TabControlNavigationService<viewModelBase> : INavigationService where viewModelBase : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<viewModelBase> _createViewModel;
        private readonly Func<TabControlMenuViewModel> _createNavigationMenuViewModel;

        public TabControlNavigationService
        (
            NavigationStore navigationStore,
            Func<viewModelBase> createViewModel,
            Func<TabControlMenuViewModel> createNavigationMenuViewModel
        )
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
            _createNavigationMenuViewModel = createNavigationMenuViewModel;
        }

        public void Navigate( object parameter = null )
        {
            _navigationStore.currentViewModel = new ProductWindowsViewModel(_createNavigationMenuViewModel(), _createViewModel());
        }
    }
}
