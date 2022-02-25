namespace MasayaNaturistCenter.Model.Models
{
    using System.Collections.Generic;

    public partial class Patient
    {
        public Patient()
        {
            consult = new HashSet<Consult>();
        }

        public int idPatient { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public int age { get; set; }

        public ICollection<Consult> consult { get; set; }
    }
}
