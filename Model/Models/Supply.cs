namespace MasayaNaturistCenter.Model.Models
{
    using System.Collections.Generic;

    public partial class Supply
    {
        public Supply()
        {
            supplyDetail = new HashSet<SupplyDetail>();
        }

        public int idSupply{ get; set; }
        public int idProvider { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public float total { get; set; }

        public Provider provider { get; set; }
        public ICollection<SupplyDetail> supplyDetail{ get; set; }
    }
}
