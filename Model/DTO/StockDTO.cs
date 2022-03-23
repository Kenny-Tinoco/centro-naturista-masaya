using MasayaNaturistCenter.Model.Utilities;

namespace MasayaNaturistCenter.Model.DTO
{
    public class StockDTO : BaseDTO
    {
        public int idStock { get; set; }
        public int idProduct { get; set;}
        public string name {get; set;}
        public string description {get; set;}
        public int idPresentation { get; set; }
        public string presentation { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public Date entryDate { get; set; }
        public Date expiration { get; set; }
    }
}
