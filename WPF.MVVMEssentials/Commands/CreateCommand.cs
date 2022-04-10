using WPF.MVVMEssentials.ViewModels;
using System.Windows.Input;

namespace WPF.MVVMEssentials.Commands
{
    public delegate ICommand CreateCommand<TViewModel>(TViewModel viewModel) where TViewModel : ViewModelBase;
}
