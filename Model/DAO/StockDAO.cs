using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.Models;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model.DAO
{
    public class StockDAO : IStockDAO
    {
        private MasayaNaturistCenterContext masayaNaturistCenterContext;

        public StockDAO(MasayaNaturistCenterContext masayaNaturistCenterContext)
        {
            Contract.Requires(masayaNaturistCenterContext != null);
            this.masayaNaturistCenterContext = masayaNaturistCenterContext;
        }


        public void add(StockDTO param)
        {
            var stockDTO = new StockDTO
            {
                idProductStock = param.idProductStock,
                idProduct = param.idProduct,
                idPresentation = param.idPresentation,
                quantity = param.quantity,
                price = param.price,
                entryDate = param.entryDate,
                expiration = param.expiration
            };
            masayaNaturistCenterContext.Stock.Add(stockDTO);
        }

        public void delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public StockDTO find(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<StockDTO> get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<StockDTO> getAll()
        {
            throw new System.NotImplementedException();
        }

        public void update(StockDTO objet)
        {
            throw new System.NotImplementedException();
        }
    }
}
