namespace MasayaNaturistCenter.Model.DTO
{
    public class StockDTO
    {
        public int idStock { get; set; }
        public int idProduct { get; set; }
        public int idPresentation { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public Date entryDate { get; set; }
        public Date expiration { get; set; }
    }
}
