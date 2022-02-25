namespace MasayaNaturistCenter.Model.Models
{
    public partial class SupplyDetail
    {
        public int idSupplyDetail { get; set; }
        public int idSupply { get; set; }
        public int idStock { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public float total { get; set; }

        public Supply supply { get; set; }
        public Stock stock { get; set; }
    }
}