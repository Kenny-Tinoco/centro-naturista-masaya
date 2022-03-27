using MasayaNaturistCenter.Command;
using MasayaNaturistCenter.Services;
using System.Windows.Input;

namespace MasayaNaturistCenter.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to my application.";
        public ICommand navigateLoginCommand { get; }

        public HomeViewModel(INavigationService logicNavigationService)
        {
            navigateLoginCommand = new NavigateCommand(logicNavigationService);
        }
    }
}
