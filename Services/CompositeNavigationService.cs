using System.Collections.Generic;

namespace MasayaNaturistCenter.Services
{
    public class CompositeNavigationService : INavigationService
    {
        private readonly IEnumerable<INavigationService> _navigationServices;

        public CompositeNavigationService(params INavigationService[] navigationServices )
        {
            _navigationServices = navigationServices;
        }

        public void Navigate(object parameter = null)
        {
            foreach(INavigationService navigationService in _navigationServices)
            {
                navigationService.Navigate();
            }
        }
    }
}
