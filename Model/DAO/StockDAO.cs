using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;

namespace MasayaNaturistCenter.Model.DAO
{
    public class StockDAO : IStockDAO
    {
        private MasayaNaturistCenterEntity dataBaseContext; 

        public StockDAO(MasayaNaturistCenterEntity dataBaseContext)
        {
            Contract.Requires(dataBaseContext != null);
            this.dataBaseContext = dataBaseContext;
        }

        public void add(StockDTO parameter)
        {
            var stock = getStockOf(parameter);

            dataBaseContext.Stock.AddObject(stock);
            dataBaseContext.SaveChanges();
        }

        public void delete(int id)
        {
            var stock = findStock(id);
            if(stock != null)
            {
                dataBaseContext.Stock.DeleteObject(stock);
                dataBaseContext.SaveChanges();
            }
        }

        public StockDTO find(int id)
        {
            var stockDTO = new StockDTO();

            var stock = findStock(id);

            if (stock == null)
                return null;
            else
                stockDTO = getStockDTOof(stock);

            return stockDTO;
        }

        public List<StockDTO> get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<StockDTO> getAll()
        {
            var list = new List<StockDTO>();

            var stocks = dataBaseContext.Stock.ToList();

            list.AddRange(stocks.Select(stock => getStockDTOof(stock)).ToList());

            return list;
        }

        public void update(StockDTO parameter)
        {
            delete(parameter.idStock);
            add(parameter);
        }


        private Models.Stock getStockOf(StockDTO parameter)
        {
            var stock = new Models.Stock
            {
                idStock = parameter.idStock,
                idProduct = parameter.idProduct,
                idPresentation = parameter.idPresentation,
                quantity = parameter.quantity,
                price = parameter.price,
                entryDate = parameter.entryDate.getDateString(),
                expiration = parameter.expiration.getDateString()
            };

            return stock;
        }

        private StockDTO getStockDTOof(Models.Stock parameter)
        {
            var stockDTO = new StockDTO
            {
                idStock = parameter.idStock,
                idProduct = parameter.idProduct,
                idPresentation = parameter.idPresentation,
                quantity = parameter.quantity,
                price = parameter.price,
                entryDate = new Date().getStringOfDate(parameter.entryDate),
                expiration = new Date().getStringOfDate(parameter.expiration)
            };

            return stockDTO;
        }

        private Models.Stock findStock(int id)
        {
            var stock = dataBaseContext.Stock.AsNoTracking().SingleOrDefault(stock => stock.idStock == id);
            return stock;
        }
    }
}
