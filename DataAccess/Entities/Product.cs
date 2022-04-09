namespace DataAccess.SqlServerDataSource
{
    public partial class Product : BaseEntity
    {
        public int idProduct { get; set; }
        public string name { get; set; } = null!;
        public string? description { get; set; }
        public int quantity { get; set; }
    }
}
