using MasayaNaturistCenter.Stores;
using MasayaNaturistCenter.ViewModel;
using System;

namespace MasayaNaturistCenter.Services
{
    public class NavigationService<viewModelBase> : INavigationService 
                                                    where viewModelBase : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<viewModelBase> _createViewModel;

        public NavigationService(NavigationStore navigationStore, Func<viewModelBase> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            _navigationStore.currentViewModel = _createViewModel();
        }
    }
}
