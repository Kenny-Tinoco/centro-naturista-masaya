using Domain.Entities;
using Domain.Logic;
using MVVMGenericStructure.Commands;
using MVVMGenericStructure.Services;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using WPF.Command.CRUD;
using WPF.Command.Navigation;

namespace WPF.ViewModel
{
    public class ProductViewModel : ViewModelGeneric<Product>
    {
        public INavigationService _navigationService;

        public ICommand openModalCommand { get; }


        public ProductViewModel(BaseLogic<Product> parameter, INavigationService modalNavigationService) : base((ProductLogic)parameter)
        {
            _navigationService = modalNavigationService;
            openModalCommand = new NavigateCommand(_navigationService);

            addCommand = new RelayCommand(parameter => addModal());
            editCommand = new RelayCommand(parameter => editModal((Product)parameter)); 
            deleteCommand = new RelayCommand(parameter => delete((Product)parameter));
        }


        public static ProductViewModel LoadViewModel(BaseLogic<Product> parameter, INavigationService navigationService)
        {
            ProductViewModel viewModel = new ProductViewModel(parameter, navigationService);

            viewModel.LoadCatalogueCommand.Execute(null);

            return viewModel;
        }

        private string _searchText;
        public string searchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                _searchText = value;
                search();
            }
        }

        public void search()
        {
            if (validateSearchString(searchText))
            {
                dataGridSource.Filter = DataGridSource_Filter;
            }
            else if (searchText.Equals(""))
            {
                dataGridSource.Filter = null;
            }
        }

        private bool DataGridSource_Filter(object obj)
        {
            if (obj is Product element)
            {
                return ((ProductLogic)logic).searchLogic(element, searchText);
            }

            return false;
        }

        public ICollectionView dataGridSource => CollectionViewSource.GetDefaultView(catalogue);
           
   
        public ICommand addCommand { get; }
        public void addModal()
        {
            isEditable = false;
            logic.resetEntity();
            openModalCommand.Execute(-1);
        }


        public ICommand editCommand { get; }
        public void editModal(Product parameter)
        {
            logic.entity = parameter;
            isEditable = true;
            openModalCommand.Execute(-1);
        }


        public ICommand deleteCommand { get; }
        public async void delete(Product parameter)
        {
            var result = MessageBox
                .Show("¿Está seguro de eliminar este producto?", "Confirmar Eliminación", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
                await new DeleteCommand<Product>(logic).ExecuteAsync(parameter);
        }
    }
}
