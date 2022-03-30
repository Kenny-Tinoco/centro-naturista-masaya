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
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.ViewModel.Components;

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


            services.AddSingleton<LogicFactory>();

            services.AddSingleton<CloseModalNavigationService>();



            services.AddTransient<StockModalViewModel>(s => createStockModaViewModel(s));
            services.AddTransient<PresentationModalViewModel>
            (
               s => new PresentationModalViewModel
               (
                   s.GetRequiredService<CloseModalNavigationService>(),
                   s.GetRequiredService<LogicFactory>().presentationModalLogic
               )
            );
            services.AddSingleton<ProductViewModel>(s => createProductViewModel(s));
            services.AddSingleton<StockViewModel>(s => createStockViewModel(s));
            services.AddSingleton<HomeViewModel>(s => new HomeViewModel(createStockNavigationService(s)));

            services.AddSingleton<INavigationService>(s => createHomeNavigationService(s));


            services.AddTransient<TabControlMenuViewModel>(s => createTabControlMenuViewModel(s));
            services.AddSingleton<ProductWindowsViewModel>(services => createProductWindowsViewModel(services));
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


        private StartupViewModel createStartupViewModel( IServiceProvider serviceProvider )
        {
            return new StartupViewModel
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                serviceProvider.GetRequiredService<NavigationMenuViewModel>(),
                new ViewModelBase()
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

        private StockModalViewModel createStockModaViewModel( IServiceProvider serviceProvider )
        {
            return new StockModalViewModel
            (
                serviceProvider.GetRequiredService<CloseModalNavigationService>(), 
                new StockDTO { name="Este es un objeto de prueba" }
            );
        }

        private StockViewModel createStockViewModel( IServiceProvider serviceProvider )
        {
            return new StockViewModel
            (
                serviceProvider.GetRequiredService<LogicFactory>().stockLogic,
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                new CompositeNavigationService
                (
                    serviceProvider.GetRequiredService<CloseModalNavigationService>()
                )
            );
        }

        private ProductViewModel createProductViewModel( IServiceProvider serviceProvider )
        {
            return new ProductViewModel
            (
                serviceProvider.GetRequiredService<LogicFactory>().productLogic,
                createHomeNavigationService(serviceProvider)
            ) ;
        }


        private NavigationMenuViewModel createNavigationMenuViewModel( IServiceProvider serviceProvider )
        {
            return new NavigationMenuViewModel
            (
                createHomeNavigationService(serviceProvider),
                createProductWindowsNavigationService(serviceProvider),
                createProviderNavigationService(serviceProvider)
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


        private INavigationService createStockModalNavigationService( IServiceProvider serviceProvider )
        {
            return new ParameterNavigationService<BaseDTO, StockModalViewModel>
            (
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                (BaseDTO) => serviceProvider.GetRequiredService<StockModalViewModel>()
            );
        }

        private INavigationService createPresentationModalNavigationService( IServiceProvider serviceProvider )
        {
            return new ModalNavigationService<PresentationModalViewModel>
            (
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                () => serviceProvider.GetRequiredService<PresentationModalViewModel>()
            );
        }


        private DAOFactory createDAOFactorySQL( IServiceProvider serviceProvider )
        {
            return new DAOFactorySQL(serviceProvider.GetRequiredService<MasayaNaturistCenterDataBase>());
        }

    }
}
