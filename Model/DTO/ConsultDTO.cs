using MasayaNaturistCenter.Model.Utilities;

namespace MasayaNaturistCenter.Model.DTO
{
    public class ConsultDTO
    {
        public int idConsult {get; set;}
        public Time time {get; set;}
        public Date date {get; set;}
        public List<ProductDTO> prescriptionProducts {get; set;}
    }
}