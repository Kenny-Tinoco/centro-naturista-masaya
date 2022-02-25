namespace MasayaNaturistCenter.Model.DTO
{
    internal class StockDTO
    {
        private int _idProductStock;
        private string _idProduct;
        private int _idPresentation;
        private Date _expiration;
        private int _quantity;
        private float _price;
        private Date _entryDate;

        public int idProductStock
        { 
            get => _idProductStock;
            set => _idProductStock = value;
        }

        public string idProduct
        {
            get => _idProduct;
            set => _idProduct = value;
        }

        public int idPresentation 
        { 
            get => _idPresentation; 
            set => _idPresentation = value; 
        }

        public int quantity 
        { 
            get => _quantity; 
            set => _quantity = value; 
        }

        public float price 
        { 
            get => _price; 
            set => _price = value; 
        }

        public Date expiration 
        { 
            get => _expiration; 
            set => _expiration = value; 
        }
        
        public Date entryDate 
        { 
            get => _entryDate; 
            set => _entryDate = value;
        }
    }
}
