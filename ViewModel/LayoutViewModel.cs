using MasayaNaturistCenter.ViewModel.Command;
using System.Windows.Input;

namespace MasayaNaturistCenter.ViewModel
{
    public class LayoutViewModel : ViewModelBase
    {
        public ICommand stateBarCommand { get; } 
        public NavigationMenuViewModel navigationMenuViewModel { get; }
        public ViewModelBase contentViewModel { get; }

        public LayoutViewModel
            (
                NavigationMenuViewModel navigationMenuViewModel, 
                ViewModelBase contentViewModel
            )
        {
            this.navigationMenuViewModel = navigationMenuViewModel;
            this.contentViewModel = contentViewModel;
            stateBarCommand = new StateBarCommand();
            stateBarCommand = new StateBarCommand();
        }

        public override void Dispose()
        {
            navigationMenuViewModel.Dispose();
            contentViewModel.Dispose();
            base.Dispose();
        }
    }
}
