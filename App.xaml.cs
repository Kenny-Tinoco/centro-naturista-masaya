using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.DAO.SqlServer;
using MasayaNaturistCenter.Model.DataSource;
using MasayaNaturistCenter.View;
using MasayaNaturistCenter.ViewModel;
using MasayaNaturistCenter.Services;
using MasayaNaturistCenter.Stores;
using MasayaNaturistCenter.Logic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace MasayaNaturistCenter
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;


        public App()
        {
            IServiceCollection services = new ServiceCollection();

            addServices(services);

            _serviceProvider = services.BuildServiceProvider();
        }


        protected override void OnStartup( StartupEventArgs e )
        {
            INavigationService initialNavigationService = _serviceProvider.GetRequiredService<INavigationService>();
            initialNavigationService.Navigate();

            MainWindow = _serviceProvider.GetRequiredService<Startup>();
            MainWindow.Show();

            base.OnStartup(e);
        }


        private void addServices( IServiceCollection services )
        {
            services.AddSingleton<NavigationStore>();
            services.AddSingleton<ModalNavigationStore>();
            services.AddSingleton<MasayaNaturistCenterDataBase>();
            services.AddSingleton<DAOFactory>(s => createDAOFactorySQL(s));


            services.AddSingleton<StockLogic>();
            services.AddSingleton<ProductLogic>();

            services.AddSingleton<CloseModalNavigationService>();


            services.AddTransient<StockModalViewModel>(s => createStockModaViewModel(s));
            services.AddSingleton<ProductViewModel>(s => createProductViewModel(s));
            services.AddSingleton<StockViewModel>(s => createStockViewModel(s));
            services.AddSingleton<HomeViewModel>(s => new HomeViewModel(createProductPageNavigationService(s)));

            services.AddSingleton<INavigationService>(s => createHomePageNavigationService(s));

            services.AddTransient<NavigationMenuViewModel>(createNavigationMenuViewModel);

            services.AddSingleton<StartupViewModel>();
            services.AddSingleton
            (
                s => new Startup()
                {
                    DataContext = s.GetRequiredService<StartupViewModel>()
                }
            );
        }

        private StockModalViewModel createStockModaViewModel( IServiceProvider serviceProvider )
        {
            CompositeNavigationService navigationService = new CompositeNavigationService
            (
                serviceProvider.GetRequiredService<CloseModalNavigationService>()
            );

            return new StockModalViewModel(navigationService);
        }

        private DAOFactory createDAOFactorySQL( IServiceProvider serviceProvider )
        {
            return new DAOFactorySQL(serviceProvider.GetRequiredService<MasayaNaturistCenterDataBase>());
        }

        private StockViewModel createStockViewModel( IServiceProvider serviceProvider )
        {
            //CompositeNavigationService navigationService = new CompositeNavigationService
            //(
            //    createProductNavigationService(serviceProvider),
            //    createStockModalNavigationService(serviceProvider)
            //);
            return new StockViewModel
            (
                serviceProvider.GetRequiredService<StockLogic>(),
                createProductNavigationService(serviceProvider),
                createStockModalNavigationService(serviceProvider)
            );
        }

        private ProductViewModel createProductViewModel( IServiceProvider serviceProvider )
        {
            return new ProductViewModel
            (
                serviceProvider.GetRequiredService<ProductLogic>(),
                createStockModalNavigationService(serviceProvider)
            ) ;
        }

        private NavigationMenuViewModel createNavigationMenuViewModel( IServiceProvider serviceProvider )
        {
            return new NavigationMenuViewModel
            (
                createHomePageNavigationService(serviceProvider),
                createProductPageNavigationService(serviceProvider)
            );
        }

        private INavigationService createProductPageNavigationService( IServiceProvider serviceProvider )
        {
            return new LayoutNavigationService<StockViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<StockViewModel>(),
                () => serviceProvider.GetRequiredService<NavigationMenuViewModel>()
            );
        }

        private INavigationService createProductNavigationService( IServiceProvider serviceProvider )
        {
            return new LayoutNavigationService<ProductViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService <ProductViewModel>(),
                () => serviceProvider.GetRequiredService<NavigationMenuViewModel>()
            );
        }

        private INavigationService createHomePageNavigationService(IServiceProvider serviceProvider)
        {
            return new LayoutNavigationService<HomeViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<HomeViewModel>(),
                () => serviceProvider.GetRequiredService<NavigationMenuViewModel>()
            );
        }
        private INavigationService createStockModalNavigationService( IServiceProvider serviceProvider )
        {
            return new ModalNavigationService<StockModalViewModel>
            (
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                () => serviceProvider.GetRequiredService<StockModalViewModel>()
            );
        }
    }
}
