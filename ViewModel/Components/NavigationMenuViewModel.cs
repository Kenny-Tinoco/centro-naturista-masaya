using MasayaNaturistCenter.Command;
using MasayaNaturistCenter.Services;
using System.Windows.Input;

namespace MasayaNaturistCenter.ViewModel
{
    public class NavigationMenuViewModel : ViewModelBase
    {
        private bool _isMenuOpen;
        public bool isMenuOpen
        {
            get
            {   
                return _isMenuOpen; 
            }
            set
            {
                _isMenuOpen = value;
                OnPropertyChanged(nameof(isMenuOpen));
            }
        }

        public ICommand navigateHomeCommand { get; }
        public ICommand navigateProductCommand { get; }
        public ICommand navigateProviderCommand { get; }
        public ICommand navigateEmployeeCommand { get; }

        public NavigationMenuViewModel
            (
                INavigationService navigateHomeCommand,
                INavigationService navigateProductCommand,
                INavigationService navigateProviderCommand
            )
        {
            isMenuOpen = true;
            this.navigateHomeCommand = new NavigateCommand(navigateHomeCommand);
            this.navigateProductCommand = new NavigateCommand(navigateProductCommand);
            this.navigateProviderCommand = new NavigateCommand(navigateProviderCommand);

        }
    }
}
