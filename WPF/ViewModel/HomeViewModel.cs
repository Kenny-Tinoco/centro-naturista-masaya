using System.Windows.Input;
using WPF.MVVMEssentials.Commands;
using WPF.MVVMEssentials.Services;
using WPF.MVVMEssentials.ViewModels;

namespace WPF.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        public ICommand navigateLoginCommand { get; }

        public HomeViewModel(INavigationService logicNavigationService)
        {
            navigateLoginCommand = new NavigateCommand(logicNavigationService);
        }
    }
}
