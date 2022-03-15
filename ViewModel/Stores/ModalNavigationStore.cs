using System;

namespace MasayaNaturistCenter.ViewModel.Stores
{
    public class ModalNavigationStore
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
