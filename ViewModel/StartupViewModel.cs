using System.Diagnostics.Contracts;
using MasayaNaturistCenter.ViewModel.Stores;

namespace MasayaNaturistCenter.ViewModel
{
    public class StartupViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly ModalNavigationStore _modalNavigationStore;


        public ViewModelBase currentViewModel => _navigationStore.currentViewModel;
        public ViewModelBase currentModalViewModel => _modalNavigationStore.currentViewModel;

        public bool isOpen => _modalNavigationStore.isOpen;


        public StartupViewModel
        (
            NavigationStore navigationStore,
            ModalNavigationStore modalNavigationStore
        )
        {
            Contract.Requires(navigationStore != null && modalNavigationStore != null);

            _navigationStore = navigationStore;
            _modalNavigationStore = modalNavigationStore;

            _navigationStore.currentViewModelChanged += OnCurrentViewModelChanged;
            _modalNavigationStore.currentViewModelChanged += OnCurrentModalViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(currentViewModel));
        }

        private void OnCurrentModalViewModelChanged()
        {
            OnPropertyChanged(nameof(currentModalViewModel));
        }
    }
}
