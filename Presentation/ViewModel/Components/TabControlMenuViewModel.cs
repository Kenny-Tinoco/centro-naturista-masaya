using MasayaNaturistCenter.Command;
using MasayaNaturistCenter.Services;
using System.Windows.Input;

namespace MasayaNaturistCenter.ViewModel.Components
{
    public class TabControlMenuViewModel : ViewModelBase
    {
        public ICommand navigateStockPage { get; }
        public ICommand navigateProductPage { get; }
        public ICommand navigatePresentationModal { get; }

        public TabControlMenuViewModel
            (
                INavigationService navigateStockService,
                INavigationService navigateProductService,
                INavigationService navigatePresentationSevice
            )
        { 
            navigateStockPage = new NavigateCommand(navigateStockService);
            navigateProductPage = new NavigateCommand(navigateProductService);
            navigatePresentationModal = new NavigateCommand(navigatePresentationSevice);
        }
    }
}
