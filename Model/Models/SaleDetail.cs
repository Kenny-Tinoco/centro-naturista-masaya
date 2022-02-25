namespace MasayaNaturistCenter.Model.Models
{
    public partial class SaleDetail
    {
        public int idSaleDetail { get; set; }
        public int idSell { get; set;}
        public int idStock { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public float total { get; set; }

        public Sell sell { get; set; }
        public Stock stock { get; set; }

    }
}