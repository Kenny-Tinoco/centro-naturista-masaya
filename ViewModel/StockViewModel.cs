using MasayaNaturistCenter.Model.DTO;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MasayaNaturistCenter.ViewModel.Command;
using System.Windows.Data;
using System.ComponentModel;
using System.Windows.Input;
using MasayaNaturistCenter.X;
using MasayaNaturistCenter.ViewModel.Services;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockViewModel : CRUDCommand
    {
        private ObservableCollection<StockDTO> _stockList;
        public INavigationService navigationService;
        public IX stockX;

        private string _searchText;
        private CollectionViewSource _dataGridSource;

        public ICommand addStockCommand { get; }


        public StockViewModel(IX parameter, INavigationService navigation)
        {
            Contract.Requires(parameter != null);
            stockX = parameter;

            addStockCommand = new NavigateCommand(navigation);

            stockList = new ObservableCollection<StockDTO>();

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
            get{ return DataGridSource.View;}
        }

        public ObservableCollection<StockDTO> stockList
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
            getStockList(((StockX)stockX).getAll());
        }

        public void searchStock(string parameter)
        {
            getStockList(((StockX)stockX).getAllOccurrencesOf(parameter));
        }

        public override void saveData(StockDTO parameter)
        {
            ((StockX)stockX).currentStock = parameter;
            ((StockX)stockX).saveStock();
        }

        public override void deleteElement(int parameter)
        {
            ((StockX)stockX).deleteStock(parameter);
        }


        private void getStockList(List<BaseDTO> list)
        {
            var stocks = new ObservableCollection<StockDTO>();
            list.ForEach(element => stocks.Add((StockDTO)element));
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
            var element = e.Item as StockDTO;
            if (element != null)
            {
                if(((StockX)stockX).searchLogic(element, searchText))
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