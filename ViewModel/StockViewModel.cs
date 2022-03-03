using MasayaNaturistCenter.Model.Utilities;
using MasayaNaturistCenter.Model.DTO;
using System.Diagnostics.Contracts;
using System.Collections.Generic;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockViewModel
    {
        public List<StockDTO> stockList;
        public StockViewModelRecords stockRecords;


        public StockViewModel(StockViewModelRecords parameter)
        {
            Contract.Requires(parameter != null);
            stockRecords = parameter;
        }

        public getAllStock()
        {
            stockList = stockRecords.getAll();
        }

        public searchStock(string parameter)
        {
            stockList = stockRecords.getAllOccurrencesOf(parameter);
        }
    }
}