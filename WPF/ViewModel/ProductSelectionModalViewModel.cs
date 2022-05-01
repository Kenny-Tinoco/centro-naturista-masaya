using Domain.Entities;
using Domain.Logic;
using MVVMGenericStructure.Services;
using MVVMGenericStructure.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Command.CRUD;
using WPF.Command.Navigation;
using WPF.ViewModel.Base;

namespace WPF.ViewModel
{
    public class ProductSelectionModalViewModel : ViewModelCatalogue<Product>
    {
        public string titleBar { get; }

        public ICommand exitCommand { get; }
        public ICommand _goCommand;

        public BaseLogic<Product> logic { get; }


        public ProductSelectionModalViewModel(BaseLogic<Product> parameter, INavigationService closeModalNavigationService ) : base((ProductLogic)parameter)
        {
            exitCommand = new ExitModalCommand(closeModalNavigationService);
            titleBar = "Selecionar un producto";
        }


        public static ProductSelectionModalViewModel LoadViewModel(BaseLogic<Product> _logic, INavigationService closeModalNavigationService )
        {
            ProductSelectionModalViewModel viewModel = new ProductSelectionModalViewModel(_logic, closeModalNavigationService);

            viewModel.LoadCatalogueCommand.Execute(null);

            return viewModel;
        }


        public ICommand goCommand
        {
            get
            {
                if (_goCommand == null)
                    _goCommand = new RelayCommand(parameter => go((Product)parameter), null);

                return _goCommand;
            }
        }

        public void go( Product parameter )
        {
            logic.entity = parameter;
            exitCommand.Execute(-1);
        }



    }
}
