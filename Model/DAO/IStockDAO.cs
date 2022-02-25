using MasayaNaturistCenter.Model.DTO;
using System.Collections.Generic;

namespace MasayaNaturistCenter.Model.DAO
{
    public interface IStockDAO
    {
        List<StockDTO> getAll();
        public List<StockDTO> get(int id);
        StockDTO find(int id);
        public void add(StockDTO objet);
        public void update(StockDTO objet);
        public void delete(int id);
    }
}