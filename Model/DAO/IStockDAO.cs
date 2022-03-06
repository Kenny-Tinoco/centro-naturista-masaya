using MasayaNaturistCenter.Model.DTO;
using System.Collections.Generic;

namespace MasayaNaturistCenter.Model.DAO
{
    public interface IStockDAO
    {
        void add(StockDTO parameter);
        void delete(int id);
        void update(StockDTO parameter);
        List<StockDTO> getAll();
        List<StockDTO> getAllOccurrencesOf(string parameter);
    }
}