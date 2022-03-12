using MasayaNaturistCenter.Model.DTO;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using MasayaNaturistCenter.ViewModel.Command;
using System.Windows.Data;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockViewModel : CRUDCommand
    {
        private ObservableCollection<StockDTO> _stockList;
        public StockViewModelRecords stockRecords;


        public string searchText { get; set; }
        public CollectionViewSource dataGridSource;


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
                dataGridSource.Filter += new FilterEventHandler(DataGridSource_Filter);
            }
            else if (searchText.Equals(""))
            {
                dataGridSource.Filter += null;
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
    }
}