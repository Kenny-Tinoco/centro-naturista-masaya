namespace MasayaNaturistCenter.Model.Models
{
    using System.Collections.Generic;

    public partial class Employee
    {
        public Employee()
        {
            consult = new HashSet<Consult>();
            sell = new HashSet<Sell>();
        }

        public int idEmployee { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string position { get; set; }

        public virtual ICollection<Consult> consult { get; set; }
        public virtual ICollection<Sell> sell { get; set; }
    }
}
