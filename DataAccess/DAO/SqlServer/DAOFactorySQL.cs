using DataAccess.DAO.DAOInterfaces;
using DataAccess.Model.DataSource;
using DataAccess.Model.DTO;
using System.Diagnostics.Contracts;

namespace DataAccess.DAO.SqlServer
{
    public class DAOFactorySQL : DAOFactory
    {
        private MasayaNaturistCenterDataBase dataBaseContext;

        private ConsultDAO<ConsultDTO> _consultDAO;
        private EmployeeDAO<EmployeeDTO> _employeeDAO;
        private PatientDAO<PatientDTO> _patientDAO;
        private PrescriptionProductDAO<PrescriptionProductDTO> _prescriptionProductDAO;
        private PresentationDAO<PresentationDTO> _presentationDAO;
        private ProductDAO<ProductDTO> _productDAO;
        private ProviderDAO<ProviderDTO> _providerDAO;
        private StockDAO<StockViewDTO> _stockDAO;
        private TransactionDAO<TransactionDTO> _sellDAO;
        private TransactionDetailDAO<TransactionDetailDTO> _saleDetailDAO;
        private TransactionDAO<TransactionDTO> _supplyDAO;
        private TransactionDetailDAO<TransactionDetailDTO> _supplyDetailDAO;


        public DAOFactorySQL( MasayaNaturistCenterDataBase dataBaseContext )
        {
            Contract.Requires(dataBaseContext != null);
            this.dataBaseContext = dataBaseContext;
        }


        public override ConsultDAO<ConsultDTO> consultDAO
        {
            get
            {
                if (_consultDAO == null)
                    _consultDAO = new ConsultDAOSQL(dataBaseContext);

                return _consultDAO;
            }
        }

        public override EmployeeDAO<EmployeeDTO> employeeDAO
        {
            get
            {
                if (_employeeDAO == null)
                    _employeeDAO = new EmployeeDAOSQL(dataBaseContext);

                return _employeeDAO;
            }
        }

        public override PatientDAO<PatientDTO> patientDAO
        {
            get
            {
                if (_patientDAO == null)
                    _patientDAO = new PatientDAOSQL(dataBaseContext);

                return _patientDAO;
            }
        }

        public override PrescriptionProductDAO<PrescriptionProductDTO> prescriptionProductDAO
        {
            get
            {
                if (_prescriptionProductDAO == null)
                    _prescriptionProductDAO = new PrescriptionProductDAOSQL(dataBaseContext);

                return _prescriptionProductDAO;
            }
        }

        public override PresentationDAO<PresentationDTO> presentationDAO
        {
            get
            {
                if (_presentationDAO == null)
                    _presentationDAO = new PresentationDAOSQL(dataBaseContext);

                return _presentationDAO;
            }
        }

        public override ProviderDAO<ProviderDTO> providerDAO
        {
            get
            {
                if (_providerDAO == null)
                    _providerDAO = new ProviderDAOSQL(dataBaseContext);

                return _providerDAO;
            }
        }

        public override ProductDAO<ProductDTO> productDAO
        {
            get
            {
                if (_productDAO == null)
                    _productDAO = new ProductDAOSQL(dataBaseContext);

                return _productDAO;
            }
        }

        public override StockDAO<StockViewDTO> stockDAO
        {
            get 
            {
                if (_stockDAO == null)
                    _stockDAO = new StockDAOSQL(dataBaseContext);

                return _stockDAO; 
            }
        }

        public override TransactionDAO<TransactionDTO> sellDAO
        {
            get
            {
                if (_sellDAO == null)
                    _sellDAO = new SellDAOSQL(dataBaseContext);

                return _sellDAO;
            }
        }

        public override TransactionDetailDAO<TransactionDetailDTO> saleDetailDAO
        {
            get
            {
                if (_saleDetailDAO == null)
                    _saleDetailDAO = new SaleDetailDAOSQL(dataBaseContext);
                
                return _saleDetailDAO;
            }
        }

        public override TransactionDAO<TransactionDTO> supplyDAO
        {
            get
            {
                if (_supplyDAO == null)
                    _supplyDAO = new SupplyDAOSQL(dataBaseContext);

                return _supplyDAO;
            }
        }

        public override TransactionDetailDAO<TransactionDetailDTO> supplyDetailDAO
        {
            get
            {
                if (_supplyDetailDAO == null)
                    _supplyDetailDAO = new SupplyDetailDAOSQL(dataBaseContext);

                return _supplyDetailDAO;
            }
        }
    }
}
