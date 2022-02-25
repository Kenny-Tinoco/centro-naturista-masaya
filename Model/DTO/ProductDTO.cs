namespace MasayaNaturistCenter.Model.DTO
{
    internal class ProductDTO
    {
        private int _idProduct;
        private string _name;
        private string _description;
        private int _quantity;

        public int idProduct
        { 
            get => _idProduct; 
            set => _idProduct = value; 
        }
        public string name 
        { 
            get => _name; 
            set => _name = value; 
        }
        public string description 
        { 
            get => _description; 
            set => _description = value; 
        }
        public int quantity 
        { 
            get => _quantity; 
            set => _quantity = value; 
        }
    }
}
