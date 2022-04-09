namespace DataAccess.SqlServerDataSource
{
    public class Transaction : BaseEntity
    {
        public int idTransaction { get; set; }
        public int idTransactionRelatedObjet { get; set; }
        public DateTime date { get; set; }
        public double total { get; set; }
    }
}
