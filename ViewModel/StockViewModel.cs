using MasayaNaturistCenter.Model.DTO;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MasayaNaturistCenter.ViewModel.Command;
using System.Windows.Data;
using System.ComponentModel;
using System.Windows.Input;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockViewModel : CRUDCommand
    {
        private ObservableCollection<StockDTO> _stockList;
        public StockViewModelRecords stockRecords;

        private string _searchText;
        private CollectionViewSource _dataGridSource;

        public ICommand addStockCommand { get; }


        public StockViewModel(StockViewModelRecords parameter)
        {
            Contract.Requires(parameter != null);
            stockRecords = parameter;
            addStockCommand = new NavigateCommand(stockRecords.navigationService);

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
            getStockList(stockRecords.getAll());
        }

        public void searchStock(string parameter)
        {
            getStockList(stockRecords.getAllOccurrencesOf(parameter));
        }

        public override void saveData(StockDTO parameter)
        {
            stockRecords.logic.stock = parameter;
            stockRecords.saveStock();
        }

        public override void deleteElement(int parameter)
        {
            stockRecords.deleteStock(parameter);
        }


        private void getStockList(List<StockDTO> list)
        {
            var stocks = new ObservableCollection<StockDTO>();
            list.ForEach(element => stocks.Add(element));
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
                if(stockRecords.searchLogic(element, searchText))
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