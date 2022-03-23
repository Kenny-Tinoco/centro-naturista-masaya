using MasayaNaturistCenter.Model.Utilities;
using MasayaNaturistCenter.Model.DTO;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model.Logic
{
    public class StockLogic
    {
        private StockDTO _stock;


        public StockLogic()
        {
        }

    
        public void associateStockToProduct(ProductDTO productDTO)
        {
            Contract.Requires(productDTO != null);
            stock.idProduct = productDTO.idProduct;
            stock.name = productDTO.name;
            stock.description = productDTO.description;
        }

        public StockDTO stock
        {
            get
            {
                return _stock;
            }
            set
            {
                Contract.Requires(value != null);
                _stock = value;
            }
        }

        public double price
        {
            get
            {
                return stock.price;
            }

            set
            {
                Contract.Requires(value >= 0);
                stock.price = value;
            }
        }

        public string presentation
        {
            get
            {
                return stock.presentation;
            }

            set
            {
                stock.presentation = value;
            }
        }

        public Date entryDate
        {
            get
            {
                return stock.entryDate;
            }
            
            set
            {
                Contract.Requires(value != null);
                stock.entryDate = value;
            }
        }

        public Date expiration
        {
            get
            {
                return stock.expiration;
            }
            
            set
            {
                Contract.Requires(value != null);
                stock.expiration = value;
            }
        }

        public void reduceQuantity()
        {
            if(stock.quantity > 0)
                stock.quantity--;
        }

        public void increaseQuantity()
        {
            stock.quantity++;
        }
    }
}
