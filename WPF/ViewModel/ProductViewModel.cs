using Domain.Logic;
using WPF.Command.Crud;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using WPF.MVVMEssentials.Services;
using WPF.MVVMEssentials.Commands;
using DataAccess.Entities;
using WPF.Command.Navigation;

namespace WPF.ViewModel
{
    public class ProductViewModel : ViewModelGeneric
    {
        private ObservableCollection<Product> _recordsList;
        public INavigationService navigationService;
        public BaseLogic<Product> logic;
        private string _searchText;
        public ICommand addCommand { get; }
        public ICommand deleteCommand { get; }

        public ProductViewModel( BaseLogic<Product> parameter, INavigationService navigationService )
        {
            Contract.Requires(navigationService != null && parameter != null);
            this.navigationService = navigationService;
            logic = parameter;

            recordsList = new ObservableCollection<Product>();

            addCommand = new NavigateCommand(navigationService);
            logic.loadListRecordsCommand = new LoadRecordListCommand<Product>(this);
        }


        public static ProductViewModel LoadViewModel
        ( BaseLogic<Product> parameter, INavigationService navigationService )
        {
            ProductViewModel viewModel = new ProductViewModel(parameter, navigationService);

            viewModel.logic.loadListRecordsCommand.Execute(null);

            return viewModel;
        }


        public ObservableCollection<Product> recordsList
        {
            get { return _recordsList; }
            set 
            { 
                _recordsList = value;
                OnPropertyChanged(nameof(recordsList));
            }
        }

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

        public override async Task Initialize()
        {
            getListUpdates(await logic.getAll());
            DataGridSource.Source = recordsList;
            dataGridSource = DataGridSource.View;
        }

        private void getListUpdates( IEnumerable<Product> list )
        {
            recordsList.Clear();

            var auxiliaryList = new ObservableCollection<Product>();
            list.ToList().ForEach(element => auxiliaryList.Add(element));

            recordsList = auxiliaryList;
        }

        public void search()
        {
            if (validateSearchString(searchText))
            {
                DataGridSource.Filter += new FilterEventHandler(DataGridSource_Filter);
            }
            else if (searchText.Equals(""))
            {
                DataGridSource.Filter += null;
            }
        }

        private void DataGridSource_Filter( object sender, FilterEventArgs e )
        {
            var element = e.Item as Product;
            if (element != null)
            {
                if ((logic as ProductLogic).searchLogic(element, searchText))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private bool validateSearchString( string parameter )
        {
            Contract.Requires(parameter != null);
            bool ok = true;

            if (parameter.Trim().Equals("Búscar") || parameter.Trim().Equals(""))
            {
                ok = false;
            }

            return ok;
        }


        private ICollectionView _dataGridSourceView;
        public ICollectionView dataGridSource
        {
            get
            {
                return _dataGridSourceView;
            }
            set
            {
                _dataGridSourceView = value;
                OnPropertyChanged(nameof(dataGridSource));
            }
        }

        private CollectionViewSource _dataGridSource;
        private CollectionViewSource DataGridSource
        {
            get
            {
                if (_dataGridSource == null)
                {
                    _dataGridSource = new CollectionViewSource();
                    _dataGridSource.Source = recordsList;
                }
                return _dataGridSource;
            }
            set
            {
                _dataGridSource = value;
            }
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
            addCommand.Execute(1);
            
        }
    }
}
