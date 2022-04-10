using System;
using System.Threading.Tasks;
using WPF.MVVMEssentials.ViewModels;

namespace WPF.ViewModel
{
    public class ViewModelGeneric : ViewModelBase 
    {
        public virtual Task Initialize()
        {
            throw new NotImplementedException();
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

    }
}
