namespace DataAccess.Model.DTO
{
    public class ProductDTO : BaseDTO
    {
        public int idProduct {get; set;}
        public string name {get; set;}
        public string description {get; set;}
        public int quantity {get; set;}
    }
}
