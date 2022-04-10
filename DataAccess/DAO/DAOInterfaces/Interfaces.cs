using DataAccess.Entities;
using DataAccess.SqlServerDataSource.Views;

namespace DataAccess.DAO.DAOInterfaces
{
    public interface ConsultDAO : BaseDAO<Consult, object> 
    {
    }

    public interface EmployeeDAO : BaseDAO<Employee, object>
    {
    }

    public interface PatientDAO : BaseDAO<Patient, object>
    {
    }

    public interface PrescriptionProductDAO : BaseDAO<PrescriptionProduct, object>
    {
    }

    public interface PresentationDAO : BaseDAO<Presentation, object>
    {
    }

    public interface ProductDAO : BaseDAO<Product, object>
    {
    }

    public interface ProviderDAO : BaseDAO<Provider, object>
    {
    }

    public interface StockDAO : BaseDAO<StockView, object>
    {
    }

    public interface TransactionDAO : BaseDAO<Transaction, object>
    {
    }

    public interface TransactionDetailDAO : BaseDAO<TransactionDetail, object>
    {
    }
}
