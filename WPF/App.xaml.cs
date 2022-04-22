using WPF.View;
using WPF.ViewModel;
using WPF.Services;
using WPF.MVVMEssentials.Stores;
using System;
using System.Windows;
using WPF.ViewModel.Components;
using Domain.Logic;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using WPF.MVVMEssentials.Services;
using DataAccess.SqlServerDataSource;
using Domain.DAO;
using DataAccess.DaoSqlServer;
using Microsoft.EntityFrameworkCore;
using DataAccess;

namespace WPF
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

            var configureDbContext = new MasayaNaturistCenterDataBaseFactory().getConfigureDbContext();

            services.AddDbContext<MasayaNaturistCenterDataBase>(configureDbContext);
            services.AddSingleton<MasayaNaturistCenterDataBaseFactory>(new MasayaNaturistCenterDataBaseFactory(configureDbContext));
            
            
            services.AddSingleton<DAOFactory>(s => createDAOFactorySQL(s));


            services.AddSingleton<LogicFactory>
            (
                s => new LogicFactory
                (
                    s.GetRequiredService<DAOFactory>(),
                    new ViewsCollectionsSQL(s.GetRequiredService<MasayaNaturistCenterDataBaseFactory>())
                ) 
            );

            services.AddSingleton<CloseModalNavigationService>();



            services.AddTransient<ProductSelectionModalViewModel>(s => createStockModalViewModel(s));
            services.AddTransient<StockFormViewModel>(s => createStockFormViewModel(s));
            services.AddTransient<PresentationModalViewModel>
            (
               s => PresentationModalViewModel.LoadViewModel
               (
                   s.GetRequiredService<LogicFactory>().presentationModalLogic,
                   s.GetRequiredService<CloseModalNavigationService>()
               )
            );
            services.AddTransient<ProductModalViewModel>
            (
               s => new ProductModalViewModel
               (
                   s.GetRequiredService<LogicFactory>().productLogic,
                   s.GetRequiredService<CloseModalNavigationService>()
               )
            );
            services.AddSingleton<ProductViewModel>(s => createProductViewModel(s));
            services.AddSingleton<StockViewModel>(s => createStockViewModel(s));
            services.AddSingleton<HomeViewModel>(s => new HomeViewModel(createStockNavigationService(s)));

            services.AddSingleton<INavigationService>(s => createHomeNavigationService(s));


            services.AddTransient<TabControlMenuViewModel>(s => createTabControlMenuViewModel(s));
            services.AddSingleton<ProductWindowsViewModel>(s => createProductWindowsViewModel(s));
            services.AddTransient<NavigationMenuViewModel>(createNavigationMenuViewModel);

            services.AddSingleton<StartupViewModel>(s=>createStartupViewModel(s));
            services.AddSingleton
            (
                s => new Startup()
                {
                    DataContext = s.GetRequiredService<StartupViewModel>()
                }
            );
        }

        private ProductSelectionModalViewModel createStockModalViewModel( IServiceProvider s )
        {
            return ProductSelectionModalViewModel.LoadViewModel
            (
                s.GetRequiredService<LogicFactory>().productLogic,
                s.GetRequiredService<CloseModalNavigationService>()
            );
        }

        private StartupViewModel createStartupViewModel( IServiceProvider serviceProvider )
        {
            return new StartupViewModel
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                serviceProvider.GetRequiredService<NavigationMenuViewModel>()
            );
        }

        private ProductWindowsViewModel createProductWindowsViewModel( IServiceProvider services )
        {
            return new ProductWindowsViewModel
            (
                services.GetRequiredService<TabControlMenuViewModel>(),
                services.GetRequiredService<StockViewModel>()
            );
        }

        private StockFormViewModel createStockFormViewModel( IServiceProvider serviceProvider )
        {
            return new StockFormViewModel
            (
                serviceProvider.GetRequiredService<LogicFactory>(),
                createStockNavigationService(serviceProvider),
                createStockModalNavigationService(serviceProvider)
            );
        }

        private INavigationService createStockModalNavigationService( IServiceProvider serviceProvider )
        {
            return new NavigationService<ProductSelectionModalViewModel>
            (
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                () => serviceProvider.GetRequiredService<ProductSelectionModalViewModel>()
            );
        }

        private StockViewModel createStockViewModel( IServiceProvider serviceProvider )
        {
            return StockViewModel.LoadViewModel
            (
                serviceProvider.GetRequiredService<LogicFactory>().stockLogic, 
                createStockFormNavigationService(serviceProvider)
            );
        }

        private ProductViewModel createProductViewModel( IServiceProvider serviceProvider )
        {
            return ProductViewModel.LoadViewModel
            (
                serviceProvider.GetRequiredService<LogicFactory>().productLogic,
                createProductModalNavigationService(serviceProvider)
            ) ;
        }


        private NavigationMenuViewModel createNavigationMenuViewModel( IServiceProvider serviceProvider )
        {
            return new NavigationMenuViewModel
            (
                createHomeNavigationService(serviceProvider),
                createProductWindowsNavigationService(serviceProvider),
                createProviderNavigationService(serviceProvider), 
                createEmployeeNavigationService(serviceProvider)
            );
        }

        private INavigationService createHomeNavigationService( IServiceProvider serviceProvider )
        {
            return new NavigationService<HomeViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<HomeViewModel>()
            );
        }

        private INavigationService createProductWindowsNavigationService( IServiceProvider serviceProvider )
        {

            return new NavigationService<ProductWindowsViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<ProductWindowsViewModel>()
            );
        }

        private INavigationService createProviderNavigationService( IServiceProvider serviceProvider )
        {
            return createHomeNavigationService(serviceProvider);
        }
        private INavigationService createEmployeeNavigationService( IServiceProvider serviceProvider )
        {
            return createHomeNavigationService(serviceProvider);
        }


        private TabControlMenuViewModel createTabControlMenuViewModel( IServiceProvider serviceProvider )
        {
            return new TabControlMenuViewModel
            (
                createStockNavigationService(serviceProvider),
                createProductNavigationService(serviceProvider), 
                createPresentationModalNavigationService(serviceProvider)
            );
        }

        private INavigationService createStockNavigationService( IServiceProvider serviceProvider )
        {
            return new TabControlNavigationService<StockViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<StockViewModel>(),
                () => serviceProvider.GetRequiredService<TabControlMenuViewModel>()
            );
        }
        private INavigationService createProductNavigationService( IServiceProvider serviceProvider )
        {
            return new TabControlNavigationService<ProductViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService <ProductViewModel>(),
                () => serviceProvider.GetRequiredService<TabControlMenuViewModel>()
            );
        }


        private INavigationService createStockFormNavigationService( IServiceProvider serviceProvider )
        {
            return new TabControlNavigationService<StockFormViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<StockFormViewModel>(),
                () => serviceProvider.GetRequiredService<TabControlMenuViewModel>()
            );
        }

        private INavigationService createPresentationModalNavigationService( IServiceProvider serviceProvider )
        {
            return new NavigationService<PresentationModalViewModel>
            (
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                () => serviceProvider.GetRequiredService<PresentationModalViewModel>()
            );
        }
        private INavigationService createProductModalNavigationService( IServiceProvider serviceProvider )
        {
            return new NavigationService<ProductModalViewModel>
            (
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                () => serviceProvider.GetRequiredService<ProductModalViewModel>()
            );
        }


        private DAOFactory createDAOFactorySQL( IServiceProvider serviceProvider )
        {
            return new DAOFactorySQL(serviceProvider.GetRequiredService<MasayaNaturistCenterDataBaseFactory>());
        }

        public void AddDbContext( IServiceCollection services )
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CSCentroNaturistaMasaya"].ConnectionString;
            Action<DbContextOptionsBuilder> configureDbContext = o => o.UseSqlServer(connectionString);

            services.AddDbContext<MasayaNaturistCenterDataBase>(configureDbContext);
            services.AddSingleton<MasayaNaturistCenterDataBaseFactory>(new MasayaNaturistCenterDataBaseFactory(configureDbContext));
        }
    }
}
