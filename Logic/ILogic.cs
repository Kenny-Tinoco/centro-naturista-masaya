using MasayaNaturistCenter.Model.DTO;
using System.Collections.Generic;

namespace MasayaNaturistCenter.Logic
{
    public interface ILogic
    {
        void save(); 
        List<BaseDTO> getAll(); 
        void delete( int parameter );
    }
}
