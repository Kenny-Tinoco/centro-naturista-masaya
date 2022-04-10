using WPF.ViewModel.Components;
using System;
using WPF.MVVMEssentials.Services;
using WPF.MVVMEssentials.Stores;
using WPF.MVVMEssentials.ViewModels;

namespace WPF.Services
{
    public class TabControlNavigationService<viewModelBase> : INavigationService where viewModelBase : ViewModelBase
    {
        private readonly INavigationStore _navigationStore;
        private readonly CreateViewModel<viewModelBase> _createViewModel;
        private readonly Func<TabControlMenuViewModel> _createNavigationMenuViewModel;

        public TabControlNavigationService
        (
            INavigationStore navigationStore,
            CreateViewModel<viewModelBase> createViewModel,
            Func<TabControlMenuViewModel> createNavigationMenuViewModel
        )
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
            _createNavigationMenuViewModel = createNavigationMenuViewModel;
        }

        public void Navigate()
        {
            _navigationStore.currentViewModel = new ProductWindowsViewModel(_createNavigationMenuViewModel(), _createViewModel());
        }
    }
}
