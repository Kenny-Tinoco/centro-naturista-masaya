using MasayaNaturistCenter.Model.Utilities;
using System.Collections.Generic;

namespace MasayaNaturistCenter.Model.DTO
{
    public class TransactionDTO : BaseDTO
    {
        public int idTransaction { get; set; }
        public int idTransactionRelatedObjet { get; set; }
        public List<DetailDTO> details { get; set; }
        public Time time { get; set; }
        public Date date { get; set; }
        public double total { get; set; }
    }
}
