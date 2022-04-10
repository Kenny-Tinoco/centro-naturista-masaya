using DataAccess.Entities;
using Domain.Logic;
using System.Windows.Input;
using WPF.Command.CRUD;
using WPF.Command.Navigation;
using WPF.MVVMEssentials.Services;
using WPF.MVVMEssentials.ViewModels;

namespace WPF.ViewModel
{
    public class ProductModalViewModel : ViewModelBase
    { 
        public string titleBar
        {
            get
            {
                if (logic.isEditable)
                    return "Editar Producto";
                else
                    return "Agregar Producto";
            }
        }

        public ICommand exitCommand 
        {
            get;
        }
        public ICommand saveCommand { get; }
        public BaseLogic<Product> logic { get; }

        public ProductModalViewModel( BaseLogic<Product> parameter, INavigationService closeModalNavigationService )
        {
            logic = parameter;
            exitCommand = new ExitModalCommand(closeModalNavigationService);
            saveCommand = new SaveCommand<Product>(logic);
        }
    }
}
