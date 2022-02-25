namespace MasayaNaturistCenter.Model.Models
{
    using System.Collections.Generic;

    public partial class Product
    {
        public Product()
        {
            stock = new HashSet<Stock>();
            prescriptionProduct = new HashSet<PrescriptionProduct>();   
        }

        public int idProduct { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }

        public ICollection<Stock> stock { get; set; }
        public ICollection<PrescriptionProduct> prescriptionProduct { get; set; }
    }
}
