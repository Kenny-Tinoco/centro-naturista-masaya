namespace DataAccess.Model.DTO
{
    public class StockViewDTO : BaseDTO
    {
        public int idStock { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string presentation { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public string entryDate { get; set; }
        public string expiration { get; set; }
    }
}
