namespace Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public int idTransaction { get; set; }
        public int idRelatedObjet { get; set; }
        public DateTime date { get; set; }
        public double total { get; set; }
    }
}
