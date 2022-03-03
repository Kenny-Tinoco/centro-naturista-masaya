using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.Entities;
using MasayaNaturistCenter.Model.Utilities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;

namespace MasayaNaturistCenter.Model.DAO
{
    public class StockDAO : IStockDAO
    {
        private MasayaNaturistCenterDataBase dataBaseContext; 


        public StockDAO(MasayaNaturistCenterDataBase dataBaseContext)
        {
            Contract.Requires(dataBaseContext != null);
            this.dataBaseContext = dataBaseContext;
        }


        public void add(StockDTO parameter)
        {
            var element = getStockOf(parameter);

            dataBaseContext.Stock.AddObject(element);
            dataBaseContext.SaveChanges();
        }

        public void delete(int id)
        {
            var foundStock = findStock(id);

            if(foundStock != null)
            {
                dataBaseContext.Stock.DeleteObject(foundStock);
                dataBaseContext.SaveChanges();
            }
        }     
        
        public void update(StockDTO parameter)
        {
            delete(parameter.idStock);
            add(parameter);
        }

        public List<StockDTO> getAll()
        {
            var list = new List<StockDTO>();
            var stocks = dataBaseContext.Stock.ToList();

            list.AddRange(stocks.Select(stock => getStockDTOof(stock)).ToList());

            return list;
        } 
        
        public StockDTO get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<StockDTO> getAllOccurrencesOf(string parameter)
        {
            Contract.Requires(parameter != null);
            var foundList = 
                dataBaseContext
                .Stock
                .AsNoTracking()
                .SingleOrDefault
                (
                    element => 
                    element.idStock == int.Parse(parameter) ||
                    element.Product.name = parameter ||
                    element.Presentation.name = parameter
                ).ToList();
            var list = new List<StockDTO>();
            foreach(var item in foundList)
            {
                list.AddRange(foundList.Select(stock => getStockDTOof(stock)).ToList());
            }

            return list;
        }

        public StockDTO find(int id)
        {
            var element = new StockDTO();
            var foundStock = findStock(id);

            if (foundStock == null)
                return null;
            else
                element = getStockDTOof(foundStock);

            return element;
        }


        private Stock getStockOf(StockDTO parameter)
        {
            var dateUtilities = new DateUtilities();

            var element = new Stock
            {
                idStock = parameter.idStock,
                idProduct = parameter.idProduct,
                idPresentation = parameter.idPresentation,
                quantity = parameter.quantity,
                price = parameter.price,
                entryDate = dateUtilities.convertDateToString(parameter.entryDate),
                expiration = dateUtilities.convertDateToString(parameter.expiration)
            };

            return element;
        }

        private StockDTO getStockDTOof(Stock parameter)
        {
            var dateUtilities = new DateUtilities();

            var element = new StockDTO
            {
                idStock = parameter.idStock,
                idProduct = parameter.idProduct,
                idPresentation = parameter.idPresentation,
                quantity = parameter.quantity,
                price = parameter.price,
                entryDate = dateUtilities.convertStringToDate(parameter.entryDate),
                expiration = dateUtilities.convertStringToDate(parameter.expiration)
            };

            return element;
        }

        private Stock findStock(int id)
        {
            var foundElement = 
                dataBaseContext
                .Stock
                .AsNoTracking()
                .SingleOrDefault(element => element.idStock == id);
            
            return foundElement;
        }
    }
}
