namespace DataAccess.SqlServerDataSource
{
    public partial class PrescriptionProductView : BaseEntity
    {
        public int idPrescriptionProduct { get; set; }
        public int idProduct { get; set; }
        public string productName { get; set; } = null!;
    }
}
