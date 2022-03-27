using MasayaNaturistCenter.Model.DTO;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MasayaNaturistCenter.Command;
using System.Windows.Data;
using System.ComponentModel;
using System.Windows.Input;
using MasayaNaturistCenter.Logic;
using MasayaNaturistCenter.Services;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockViewModel : ViewModelBase
    {
        private ObservableCollection<StockViewDTO> _stockList;
        public INavigationService navigationService;
        public ILogic stockLogic;
        public StockDTO currentStock;

        private string _searchText;
        private CollectionViewSource _dataGridSource;

        public ICommand addStockCommand { get; }
        public ICommand productNavigationCommand { get; }
        public ICommand save { get; }
        public ICommand delete { get; }


        public StockViewModel( ILogic parameter, INavigationService productPageNavigation, INavigationService stockModalNavigation )
        {
            Contract.Requires(parameter != null);
            stockLogic = parameter;

            addStockCommand = new NavigateCommand(stockModalNavigation);
            productNavigationCommand = new NavigateCommand(productPageNavigation);
            save = new SaveCommand(stockLogic);
            delete = new DeleteCommand(stockLogic);

            stockList = new ObservableCollection<StockViewDTO>();

            getAllStock();
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

        public ICollectionView dataGridSource
        {
            get { return DataGridSource.View; }
        }

        public ObservableCollection<StockViewDTO> stockList
        {
            get
            {
                return _stockList;
            }
            set
            {
                _stockList = value;
                OnPropertyChanged(nameof(stockList));
            }
        }

        public void getAllStock()
        {
            getStockList(stockLogic.getAll());
        }

        public void searchStock(string parameter)
        {
            getStockList(((StockLogic)stockLogic).getAllOccurrencesOf(parameter));
        }


        private void getStockList(List<BaseDTO> list)
        {
            var stocks = new ObservableCollection<StockViewDTO>();
            list.ForEach(element => stocks.Add((StockViewDTO)element));
            stockList = stocks;
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
            var element = e.Item as StockViewDTO;
            if (element != null)
            {
                if(((StockLogic)stockLogic).searchLogic(element, searchText))
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
        
        private CollectionViewSource DataGridSource
        {
            get
            {
                if (_dataGridSource == null)
                {
                    _dataGridSource = new CollectionViewSource();
                    _dataGridSource.Source = stockList;
                }
                return _dataGridSource;
            }
        }

    }
}