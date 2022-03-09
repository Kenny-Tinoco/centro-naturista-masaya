using MasayaNaturistCenter.Model.DAO;
using MasayaNaturistCenter.Model.Entities;
using MasayaNaturistCenter.UI.VentanaInicio;
using MasayaNaturistCenter.View.ProductWindows;
using MasayaNaturistCenter.ViewModel;
using System.Windows;
using System.Windows.Navigation;

namespace MasayaNaturistCenter
{
    public partial class App : Application
    {
        private MasayaNaturistCenterDataBase dataBaseContext;
        public App()
        {
            dataBaseContext = new MasayaNaturistCenterDataBase();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var productDAO = new ProductDAO(dataBaseContext);
            var stockDAO = new StockDAO(dataBaseContext);

            var productRecords = new ProductViewModelRecords(productDAO);
            var stockRecords = new StockViewModelRecords(stockDAO);

            var productViewModel = new ProductViewModel(productRecords);
            var stockViewModel = new StockViewModel(stockRecords);

            var productPage = new ProductPage(productViewModel);
            var stockPage = new StockPage(stockViewModel, productPage);

            var startup = new Startup(stockPage);

            startup.Show();

            base.OnStartup(e);
        }
    }
}
