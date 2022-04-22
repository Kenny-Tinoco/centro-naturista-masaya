﻿using WPF.MVVMEssentials.Commands;
using WPF.MVVMEssentials.Services;

namespace WPF.Command.Navigation
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