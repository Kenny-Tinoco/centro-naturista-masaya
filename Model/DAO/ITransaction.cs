using MasayaNaturistCenter.Model.DTO;
using System.Collections.Generic;

namespace MasayaNaturistCenter.Model.DAO
{
    public interface ITransaction
    {
        void add(TransactionDTO parameter);
        void delete(int id);
        void update(TransactionDTO parameter);
        List<TransactionDTO> getAll();
        TransactionDTO get(int id); 
        object findTransaction(int id);
    }
}
