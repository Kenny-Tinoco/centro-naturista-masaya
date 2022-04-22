using Domain.Logic;
using WPF.Command.Crud;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using WPF.MVVMEssentials.Services;
using WPF.MVVMEssentials.Commands;
using WPF.Command.Navigation;
using WPF.Command.CRUD;
using System.Windows;
using Domain.Entities;

namespace WPF.ViewModel
{
    public class ProductViewModel : ViewModelGeneric
    {
        public INavigationService _navigationService;
        
        public BaseLogic<Product> logic { get; }

        public ICommand openModalCommand { get; }


        public ProductViewModel( BaseLogic<Product> parameter, INavigationService modalNavigationService )
        {
            Contract.Requires(modalNavigationService != null && parameter != null);

            _navigationService = modalNavigationService;
            logic = parameter;

            logic.loadListRecordsCommand = new LoadRecordListCommand<Product>(this);
            openModalCommand = new NavigateCommand(_navigationService);
        }


        public static ProductViewModel LoadViewModel ( BaseLogic<Product> parameter, INavigationService navigationService )
        {
            ProductViewModel viewModel = new ProductViewModel(parameter, navigationService);

            viewModel.logic.loadListRecordsCommand.Execute(null);

            return viewModel;
        }


        public override async Task Initialize()
        {
            logic.getListUpdates(await logic.getAll());
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

        private bool DataGridSource_Filter( object obj )
        {
            if (obj is Product element)
            {
                return (logic as ProductLogic).searchLogic(element, searchText);
            }

            return false;
        }

        private bool validateSearchString( string parameter )
        {
            Contract.Requires(parameter != null);

            if (parameter.Trim().Equals("Búscar") || parameter.Trim().Equals(""))
                return false;

            return true;
        }

        public ICollectionView dataGridSource
        {
            get
            {
                return CollectionViewSource.GetDefaultView(logic.recordList);
            }
        }


        private ICommand _addCommand;
        public ICommand addCommand
        {
            get
            {
                if (_addCommand == null)
                    _addCommand = new RelayCommand(parameter => add(), null);

                return _addCommand;
            }
        }

        public void add()
        {
            logic.isEditable = false;
            logic.resetCurrentDTO();
            openModalCommand.Execute(-1);
        }



        private ICommand _editCommand;
        public ICommand editCommand
        {
            get
            {
                if (_editCommand == null)
                    _editCommand = new RelayCommand(parameter => edit((Product)parameter), null);

                return _editCommand;
            }
        }

        public void edit( Product parameter )
        {
            logic.currentDTO = parameter;
            logic.isEditable = true;
            openModalCommand.Execute(-1);
        }



        private ICommand _deleteCommand;
        public ICommand deleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                    _deleteCommand = new RelayCommand(parameter => delete((Product)parameter), null);

                return _deleteCommand;
            }
        }

        public async void delete( Product parameter )
        {
            var result = MessageBox
                .Show("¿Está seguro de eliminar este producto?", "Confirmar Eliminación", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
                await new DeleteCommand<Product>(logic).ExecuteAsync(parameter);
        }
    }
}
