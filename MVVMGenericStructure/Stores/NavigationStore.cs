using MVVMGenericStructure.ViewModels;
using System;

namespace MVVMGenericStructure.Stores
{
    public class NavigationStore : INavigationStore
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase currentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel?.Dispose();
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public event Action currentViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            currentViewModelChanged?.Invoke();
        }
    }
}
