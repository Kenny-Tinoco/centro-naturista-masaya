using System.Windows.Data;
using System.Windows.Input;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using Domain.Logic;
using WPF.Command.Crud;
using WPF.MVVMEssentials.Services;
using WPF.MVVMEssentials.Commands;
using WPF.Command.CRUD;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Entities.Views;
using System.Collections.Generic;

namespace WPF.ViewModel
{
    public class StockViewModel : ViewModelGeneric
    {

        public ICommand addCommand { get; }
        public ICommand saveCommand { get; }
        public ICommand deleteCommand { get; }
        public StockLogic logic { get; }
        public ViewModelHelper<Stock> _helper;

        public IEnumerable<StockView> StockViewCatalog { get; set; } 

        public INavigationService navigationService;


        public StockViewModel
        ( BaseLogic<Stock> parameter, INavigationService addStockNavigationService )
        {
            Contract.Requires(parameter != null);
            logic = parameter as StockLogic;
            _helper = new ViewModelHelper<Stock>(logic);

            addCommand = new NavigateCommand(addStockNavigationService);
            saveCommand = new SaveCommand<Stock>(parameter,this.canCreate);
            deleteCommand = new DeleteCommand<Stock>(parameter);
        }

        public static StockViewModel LoadViewModel
        ( BaseLogic<Stock> parameter, INavigationService addStockNavigationService )
        {

            StockViewModel viewModel = new StockViewModel(parameter, addStockNavigationService);

            new LoadRecordListCommand<StockView>(viewModel).Execute(null);

            return viewModel;
        }



        public override async Task Initialize()
        {
            StockViewCatalog = await logic.viewsCollections.StockViewCatalog();
            DataGridSource.Source = StockViewCatalog;
            dataGridSource = DataGridSource.View;
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
                DataGridSource.Filter += new FilterEventHandler(DataGridSource_Filter);
            }
            else if (searchText.Equals(""))
            {
                DataGridSource.Filter += null;
            }
        }

        private void DataGridSource_Filter(object sender, FilterEventArgs e)
        {
            StockView element = e.Item as StockView;
            if (element != null)
            {
                if(logic.searchLogic(element, searchText))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private bool validateSearchString(string parameter)
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
                    _dataGridSource.Source = _helper.catalogue;
                }
                return _dataGridSource;
            }
            set
            {
                _dataGridSource = value;
            }
        }

    }
}