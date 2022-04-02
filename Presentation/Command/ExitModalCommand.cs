using MasayaNaturistCenter.Services;

namespace MasayaNaturistCenter.Command
{
    public class ExitModalCommand : CommandBase
    {
        private readonly INavigationService _navigationService;

        public ExitModalCommand( INavigationService navigationService )
        {
            _navigationService = navigationService;
        }

        public override void Execute( object parameter )
        {
            _navigationService.Navigate();
        }
    }
}
