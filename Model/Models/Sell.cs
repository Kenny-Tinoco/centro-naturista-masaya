namespace MasayaNaturistCenter.Model.Models
{
    using System.Collections.Generic;

    public partial class Sell
    {
        public Sell()
        {
            saleDetail = new HashSet<SaleDetail>();
        }

        public int idSell { get; set; }
        public int idEmployee { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public float total { get; set; }

        public Employee employee { get; set; }
        public ICollection<SaleDetail> saleDetail { get; set; }
    }
}
