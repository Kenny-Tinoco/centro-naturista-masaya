using MasayaNaturistCenter.Model.Utilities;

namespace MasayaNaturistCenter.Model.DTO
{
    public class EmployeeDTO : BaseDTO
    {
        public int idEmployee {get; set;}
        public Name name {get; set;}
        public string address {get; set;}
        public int position {get; set;}
    }
}
