using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DataSource;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class DAOFactorySQL : DAOFactory
    {
        private MasayaNaturistCenterDataBase dataBaseContext;

        private ConsultDAO _consultDAO;
        private EmployeeDAO _employeeDAO;
        private PatientDAO _patientDAO;
        private PrescriptionProductDAO _prescriptionProductDAO;
        private PresentationDAO _presentationDAO;
        private ProductDAO _productDAO;
        private ProviderDAO _providerDAO;
        private StockDAO _stockDAO;
        private TransactionDAO _sellDAO;
        private TransactionDetailDAO _saleDetailDAO;
        private TransactionDAO _supplyDAO;
        private TransactionDetailDAO _supplyDetailDAO;


        public DAOFactorySQL(MasayaNaturistCenterDataBase dataBaseContext)
        {
            Contract.Requires(dataBaseContext != null);
            this.dataBaseContext = dataBaseContext;
        }


        public override ConsultDAO consultDAO
        {
            get
            {
                if (_consultDAO == null)
                    _consultDAO = new ConsultDAOSQL(dataBaseContext);

                return _consultDAO;
            }
        }

        public override EmployeeDAO employeeDAO
        {
            get
            {
                if (_employeeDAO == null)
                    _employeeDAO = new EmployeeDAOSQL(dataBaseContext);

                return _employeeDAO;
            }
        }

        public override PatientDAO patientDAO
        {
            get
            {
                if (_patientDAO == null)
                    _patientDAO = new PatientDAOSQL(dataBaseContext);

                return _patientDAO;
            }
        }

        public override PrescriptionProductDAO prescriptionProductDAO
        {
            get
            {
                if (_prescriptionProductDAO == null)
                    _prescriptionProductDAO = new PrescriptionProductDAOSQL(dataBaseContext);

                return _prescriptionProductDAO;
            }
        }

        public override PresentationDAO presentationDAO
        {
            get
            {
                if (_presentationDAO == null)
                    _presentationDAO = new PresentationDAOSQL(dataBaseContext);

                return _presentationDAO;
            }
        }

        public override ProviderDAO providerDAO
        {
            get
            {
                if (_providerDAO == null)
                    _providerDAO = new ProviderDAOSQL(dataBaseContext);

                return _providerDAO;
            }
        }

        public override ProductDAO productDAO
        {
            get
            {
                if (_productDAO == null)
                    _productDAO = new ProductDAOSQL(dataBaseContext);

                return _productDAO;
            }
        }

        public override StockDAO stockDAO
        {
            get 
            {
                if (_stockDAO == null)
                    _stockDAO = new StockDAOSQL(dataBaseContext);

                return _stockDAO; 
            }
        }

        public override TransactionDAO sellDAO
        {
            get
            {
                if (_sellDAO == null)
                    _sellDAO = new SellDAOSQL(dataBaseContext);

                return _sellDAO;
            }
        }

        public override TransactionDetailDAO saleDetailDAO
        {
            get
            {
                if (_saleDetailDAO == null)
                    _saleDetailDAO = new SaleDetailDAOSQL(dataBaseContext);
                
                return _saleDetailDAO;
            }
        }

        public override TransactionDAO supplyDAO
        {
            get
            {
                if (_supplyDAO == null)
                    _supplyDAO = new SupplyDAOSQL(dataBaseContext);

                return _supplyDAO;
            }
        }

        public override TransactionDetailDAO supplyDetailDAO
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
