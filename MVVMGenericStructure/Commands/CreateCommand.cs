using MVVMGenericStructure.ViewModels;
using System.Windows.Input;

namespace MVVMGenericStructure.Commands
{
    public delegate ICommand CreateCommand<TViewModel>(TViewModel viewModel) where TViewModel : ViewModelBase;
}
