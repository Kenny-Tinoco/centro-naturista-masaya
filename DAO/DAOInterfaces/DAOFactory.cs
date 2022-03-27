namespace MasayaNaturistCenter.DAO.DAOInterfaces
{
    public abstract class DAOFactory
    {
        public virtual ConsultDAO consultDAO { get; }
        public virtual EmployeeDAO employeeDAO { get; }
        public virtual PatientDAO patientDAO { get; }
        public virtual PrescriptionProductDAO prescriptionProductDAO { get; }
        public virtual PresentationDAO presentationDAO { get; }
        public virtual ProductDAO productDAO { get; }
        public virtual ProviderDAO providerDAO { get; }
        public virtual StockDAO stockDAO { get; }
        public virtual TransactionDAO sellDAO { get; }
        public virtual TransactionDetailDAO saleDetailDAO { get; }
        public virtual TransactionDAO supplyDAO { get; }
        public virtual TransactionDetailDAO supplyDetailDAO { get; }
    }
}
