namespace DataAccess.SqlServerDataSource
{
    public partial class Role : BaseEntity
    {
        public int idRole { get; set; }
        public string name { get; set; } = null!;
    }
}
