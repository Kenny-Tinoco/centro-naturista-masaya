namespace MasayaNaturistCenter.Model.DTO
{
    public class StockDTO
    {
        public int idProductStock { get; set; }
        public string idProduct { get; set; }
        public int idPresentation { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public Date entryDate { get; set; }
        public Date expiration { get; set; }
    }
}
