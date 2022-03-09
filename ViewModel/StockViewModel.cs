using MasayaNaturistCenter.Model.DTO;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockViewModel : ViewModelBase
    {
        private ObservableCollection<StockDTO> _stockList;
        public StockViewModelRecords stockRecords;


        public StockViewModel(StockViewModelRecords parameter)
        {
            Contract.Requires(parameter != null);
            stockRecords = parameter;

            stockList = new ObservableCollection<StockDTO>();

            getAllStock();
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

        private void getStockList(List<StockDTO> list)
        {
            var stocks = new ObservableCollection<StockDTO>();
            list.ForEach(element => stocks.Add(element));
            stockList = stocks;
        }

        public void search(string parameter)
        {
            if (validateSearchString(parameter))
            {
                searchStock(parameter);
            }
            else if (parameter.Equals(""))
            {
                getAllStock();
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
    }
}