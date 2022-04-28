using MVVMGenericStructure.Stores;
using MVVMGenericStructure.ViewModels;

namespace MVVMGenericStructure.Services
{
    public class ParameterNavigationService<TParameter, TViewModel> where TViewModel : ViewModelBase
    {
        private readonly INavigationStore _navigationStore;
        private readonly CreateViewModel<TParameter, TViewModel> _createViewModel;

        public ParameterNavigationService(INavigationStore navigationStore, CreateViewModel<TParameter, TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate(TParameter parameter)
        {
            _navigationStore.currentViewModel = _createViewModel(parameter);
        }
    }
}
