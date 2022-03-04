using MasayaNaturistCenter.Model.DTO;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Windows;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockViewModel
    { 
        public List<StockDTO> stockList { get; set; }
        public StockViewModelRecords stockRecords;


        public StockViewModel(StockViewModelRecords parameter)
        {
            Contract.Requires(parameter != null);
            stockRecords = parameter;

            getAllStock();
        }

        public void getAllStock()
        {
            stockList = stockRecords.getAll();
        }

        public void searchStock(string parameter)
        {
            stockList = stockRecords.getAllOccurrencesOf(parameter);
        }
    }
}