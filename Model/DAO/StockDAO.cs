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
            return getStockDTOListOf(dataBaseContext.Stock.ToList());
        } 
        
        public List<StockDTO> getAllOccurrencesOf(string parameter)
        {
            return getStockDTOListOf(getWhere(parameter));
        }



        private List<Stock> getWhere(string parameter)
        {
            Contract.Requires(parameter != null);

            return dataBaseContext
                .Stock
                .Where
                (
                    element => 
                    element.idStock.ToString().Contains(parameter) ||
                    element.Product.name.ToLower().StartsWith(parameter.ToLower()) ||
                    element.Presentation.name.ToLower().StartsWith(parameter.ToLower())

                ).ToList();
        }

        private List<StockDTO> getStockDTOListOf(List<Stock> stocks)
        {
            var list = new List<StockDTO>();

            list.AddRange(stocks.Select(element => getStockDTOof(element)).ToList());

            return list;
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
                name = parameter.Product.name,
                description = parameter.Product.description,
                idPresentation = parameter.idPresentation,
                presentation = parameter.Presentation.name,
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
