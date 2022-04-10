using WPF.MVVMEssentials.ViewModels;
using System;

namespace WPF.MVVMEssentials.Stores
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
