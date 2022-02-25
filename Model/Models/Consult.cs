namespace MasayaNaturistCenter.Model.Models
{
    using System.Collections.Generic;

    public partial class Consult
    {
        public Consult()
        {
            prescriptionProduct = new HashSet<PrescriptionProduct>();
        }

        public int idConsult { get; set; }
        public int idEmployee { get; set; }
        public int idPatient { get; set; }
        public string symptom { get; set; }
        public string date { get; set; }

        public virtual Employee employee { get; set; }
        public virtual Patient patient { get; set; }

        public virtual ICollection<PrescriptionProduct> prescriptionProduct { get; set; }
    }
}
