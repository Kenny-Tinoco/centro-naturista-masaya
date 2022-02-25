namespace MasayaNaturistCenter.Model.Models
{
    public partial class ProviderPhone
    {
        public int idProviderPhone { get; set; }
        public int idProvider { get; set; }

        public Provider provider { get; set; }
    }
}
