namespace MasayaNaturistCenter.Model.Models
{
    using System.Collections.Generic;

    public partial class Provider
    {
        public Provider()
        {
        }

        public int idProvider { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string ruc { get; set; }

        public ICollection<ProviderPhone> providerPhone { get; set; }
        public ICollection<Supply> supply { get; set; }
    }
}