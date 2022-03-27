﻿using MasayaNaturistCenter.ViewModel;
using System;

namespace MasayaNaturistCenter.Stores
{
    public class NavigationStore
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
