namespace DataAccess.DAO.DAOInterfaces
{
    public interface BaseDAO<T, ID>
    {
        Task create( T element );
        Task<T> read( ID id );
        Task update( T element );
        Task deleteById( ID id );
        Task<IEnumerable<T>> getAll();
    }
}
