using MasayaNaturistCenter.ViewModel.Stores;
using System;

namespace MasayaNaturistCenter.ViewModel.Services
{
    public class LayoutNavigationService<viewModelBase> : INavigationService where viewModelBase : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<viewModelBase> _createViewModel;
        private readonly Func<NavigationMenuViewModel> _createNavigationMenuViewModel;

        public LayoutNavigationService
        (
            NavigationStore navigationStore, 
            Func<viewModelBase> createViewModel, 
            Func<NavigationMenuViewModel> createNavigationMenuViewModel
        )
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
            _createNavigationMenuViewModel = createNavigationMenuViewModel;
        }

        public void Navigate()
        {
            _navigationStore.currentViewModel = new LayoutViewModel(_createNavigationMenuViewModel(), _createViewModel());
        }
    }
}
