using MVVMGenericStructure.ViewModels;

namespace MVVMGenericStructure.Stores
{
    public interface INavigationStore
    {
        ViewModelBase currentViewModel { set; }
    }
}
