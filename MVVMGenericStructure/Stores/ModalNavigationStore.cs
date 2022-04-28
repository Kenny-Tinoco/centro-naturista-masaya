using MVVMGenericStructure.ViewModels;
using System;

namespace MVVMGenericStructure.Stores
{
    public class ModalNavigationStore : INavigationStore
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

        public bool isOpen => currentViewModel != null;

        public event Action currentViewModelChanged;

        public void Close()
        {
            currentViewModel = null;
        }

        private void OnCurrentViewModelChanged()
        {
            currentViewModelChanged?.Invoke();
        }
    }
}
