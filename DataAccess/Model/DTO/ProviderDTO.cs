namespace DataAccess.Model.DTO
{
    public class ProviderDTO : BaseDTO
    {
        public int idProvider {get; set;}
        public Name name {get; set;}
        public string address {get; set;}
        public string ruc {get; set;}
    }
}