using DataAccess.Model.DTO;

namespace DataAccess.DAO.DAOInterfaces
{
    public abstract class DAOFactory
    {
        public virtual ConsultDAO<ConsultDTO> consultDAO { get; }
        public virtual EmployeeDAO<EmployeeDTO> employeeDAO { get; }
        public virtual PatientDAO<PatientDTO> patientDAO { get; }
        public virtual PrescriptionProductDAO<PrescriptionProductDTO> prescriptionProductDAO { get; }
        public virtual PresentationDAO<PresentationDTO> presentationDAO { get; }
        public virtual ProductDAO<ProductDTO> productDAO { get; }
        public virtual ProviderDAO<ProviderDTO> providerDAO { get; }
        public virtual StockDAO<StockViewDTO> stockDAO { get; }
        public virtual TransactionDAO<TransactionDTO> sellDAO { get; }
        public virtual TransactionDetailDAO<TransactionDetailDTO> saleDetailDAO { get; }
        public virtual TransactionDAO<TransactionDTO> supplyDAO { get; }
        public virtual TransactionDetailDAO<TransactionDetailDTO> supplyDetailDAO { get; }
    }
}
