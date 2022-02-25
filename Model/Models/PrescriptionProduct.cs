namespace MasayaNaturistCenter.Model.Models
{
    using System.Collections.Generic;

    public partial class PrescriptionProduct
    {
        public PrescriptionProduct()
        {
            product = new HashSet<Product>();
            consult = new HashSet<Consult>();
        }

        public int idPrescriptionProduct { get; set; }
        public int idProduct { get; set; }
        public int idConsult { get; set; }

        public ICollection<Product> product { get; set; }
        public ICollection<Consult> consult { get; set; }
    }
}
