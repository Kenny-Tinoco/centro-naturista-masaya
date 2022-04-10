using WPF.MVVMEssentials.ViewModels;

namespace WPF.MVVMEssentials.Stores
{
    public interface INavigationStore
    {
        ViewModelBase currentViewModel { set; }
    }
}