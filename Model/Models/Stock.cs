namespace MasayaNaturistCenter.Model.Models
{
    using System.Collections.Generic;

    public partial class Stock
    {
        public Stock()
        {
            saleDetail = new HashSet<SaleDetail>();
            supplyDetail = new HashSet<SupplyDetail>();
        }

        public int idStock { get; set; }
        public int idProduct { get; set; }
        public int idPresentation { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public string entryDate { get; set; }
        public string expiration { get; set; }

        public Product product { get; set; }
        public Presentation presentation { get; set; }

        public ICollection<SaleDetail> saleDetail { get; set; }
        public ICollection<SupplyDetail> supplyDetail { get; set; }
    }
}
