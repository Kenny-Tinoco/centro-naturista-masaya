namespace MasayaNaturistCenter.Model.Models
{
    using System.Collections.Generic;

    public partial class Presentation
    {
        public Presentation()
        {
            stock = new HashSet<Stock>();
        }

        public int idPresentation { get; set; }
        public string name { get; set; }

        public ICollection<Stock> stock { get; set; }
    }
}
