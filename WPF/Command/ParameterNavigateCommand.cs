using WPF.Services;

namespace WPF.Command
{
    public class ParameterNavigateCommand : CommandBase
    {
        private readonly INavigationService _navigationService;

        public ParameterNavigateCommand( INavigationService parameterNavigationService )
        {
            _navigationService = parameterNavigationService;
        }

        public override void Execute( object parameter )
        {
            _navigationService.Navigate(parameter);
        }
    }
}
