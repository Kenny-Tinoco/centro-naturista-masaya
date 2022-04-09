using WPF.Command;
using WPF.Services;
using System.Windows.Input;

namespace WPF.ViewModel
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
