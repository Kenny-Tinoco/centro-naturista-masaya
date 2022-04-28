using Domain.Logic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WPF.MVVMEssentials.Services;
using WPF.MVVMEssentials.Stores;
using WPF.Services;
using WPF.ViewModel;
using WPF.ViewModel.Components;

namespace WPF.HostBuilders
{
    public static class AddViewModelsHostBuilderExtensions
    {
        public static IHostBuilder AddViewModels(this IHostBuilder host)
        {
            host.ConfigureServices
            (services =>
            {
                services.AddTransient<ProductSelectionModalViewModel>(s => createStockModalViewModel(s));
                services.AddTransient<StockFormViewModel>(s => createStockFormViewModel(s));
                services.AddTransient<PresentationModalViewModel>(s => createPresentationModalViewModel(s));
                services.AddTransient<ProductModalViewModel>(s => createProductModalViewModel(s));

                services.AddSingleton<ProductViewModel>(s => createProductViewModel(s));
                services.AddSingleton<StockViewModel>(s => createStockViewModel(s));
                services.AddSingleton<HomeViewModel>(s => createHomeViewModel(s));

                services.AddSingleton<INavigationService>(s => createHomeNavigationService(s));

                services.AddTransient<TabControlMenuViewModel>(s => createTabControlMenuViewModel(s));
                services.AddSingleton<ProductWindowsViewModel>(s => createProductWindowsViewModel(s));
                services.AddSingleton<NavigationMenuViewModel>(s => createNavigationMenuViewModel(s));

                services.AddSingleton<StartupViewModel>(s => createStartupViewModel(s));
            }
            );

            return host;
        }

        private static HomeViewModel createHomeViewModel(IServiceProvider serviceProvider)
        {
            return new HomeViewModel
            (
                createStockFormNavigationService(serviceProvider)
            );
        }
        private static StockViewModel createStockViewModel(IServiceProvider serviceProvider)
        {
            return StockViewModel.LoadViewModel
            (
                serviceProvider.GetRequiredService<LogicFactory>().stockLogic,
                createStockFormNavigationService(serviceProvider)
            );
        }
        private static ProductViewModel createProductViewModel(IServiceProvider serviceProvider)
        {
            return ProductViewModel.LoadViewModel
            (
                serviceProvider.GetRequiredService<LogicFactory>().productLogic,
                createProductModalNavigationService(serviceProvider)
            );
        }
        private static StartupViewModel createStartupViewModel(IServiceProvider serviceProvider)
        {
            return new StartupViewModel
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                serviceProvider.GetRequiredService<NavigationMenuViewModel>()
            );
        }
        private static StockFormViewModel createStockFormViewModel(IServiceProvider serviceProvider)
        {
            return new StockFormViewModel
            (
                serviceProvider.GetRequiredService<LogicFactory>(),
                createStockNavigationService(serviceProvider),
                createStockModalNavigationService(serviceProvider)
            );
        }
        private static ProductWindowsViewModel createProductWindowsViewModel(IServiceProvider services)
        {
            return new ProductWindowsViewModel
            (
                services.GetRequiredService<TabControlMenuViewModel>(),
                services.GetRequiredService<StockViewModel>()
            );
        }
        private static ProductSelectionModalViewModel createStockModalViewModel(IServiceProvider s)
        {
            return ProductSelectionModalViewModel.LoadViewModel
            (
                s.GetRequiredService<LogicFactory>().productLogic,
                s.GetRequiredService<CloseModalNavigationService>()
            );
        }
        private static PresentationModalViewModel createPresentationModalViewModel(IServiceProvider s)
        {
            return PresentationModalViewModel.LoadViewModel
            (
                s.GetRequiredService<LogicFactory>().presentationModalLogic,
                s.GetRequiredService<CloseModalNavigationService>()
            );
        }
        private static ProductModalViewModel createProductModalViewModel(IServiceProvider s)
        {
            return new ProductModalViewModel
            (
                s.GetRequiredService<LogicFactory>().productLogic,
                s.GetRequiredService<CloseModalNavigationService>()
            );
        }
        private static NavigationMenuViewModel createNavigationMenuViewModel(IServiceProvider serviceProvider)
        {
            return new NavigationMenuViewModel
            (
                createHomeNavigationService(serviceProvider),
                createProductWindowsNavigationService(serviceProvider),
                createProviderNavigationService(serviceProvider),
                createEmployeeNavigationService(serviceProvider)
            );
        }
        private static TabControlMenuViewModel createTabControlMenuViewModel(IServiceProvider serviceProvider)
        {
            return new TabControlMenuViewModel
            (
                createStockNavigationService(serviceProvider),
                createProductNavigationService(serviceProvider),
                createPresentationModalNavigationService(serviceProvider)
            );
        }


        private static INavigationService createHomeNavigationService(IServiceProvider serviceProvider)
        {
            return new NavigationService<HomeViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<HomeViewModel>()
            );
        }
        private static INavigationService createProductWindowsNavigationService(IServiceProvider serviceProvider)
        {

            return new NavigationService<ProductWindowsViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<ProductWindowsViewModel>()
            );
        }
        private static INavigationService createProviderNavigationService(IServiceProvider serviceProvider)
        {
            return createHomeNavigationService(serviceProvider);
        }
        private static INavigationService createEmployeeNavigationService(IServiceProvider serviceProvider)
        {
            return createHomeNavigationService(serviceProvider);
        }
        private static INavigationService createStockNavigationService(IServiceProvider serviceProvider)
        {
            return new TabControlNavigationService<StockViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<StockViewModel>(),
                () => serviceProvider.GetRequiredService<TabControlMenuViewModel>()
            );
        }
        private static INavigationService createProductNavigationService(IServiceProvider serviceProvider)
        {
            return new TabControlNavigationService<ProductViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<ProductViewModel>(),
                () => serviceProvider.GetRequiredService<TabControlMenuViewModel>()
            );
        }
        private static INavigationService createStockModalNavigationService(IServiceProvider serviceProvider)
        {
            return new NavigationService<ProductSelectionModalViewModel>
            (
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                () => serviceProvider.GetRequiredService<ProductSelectionModalViewModel>()
            );
        }
        private static INavigationService createStockFormNavigationService(IServiceProvider serviceProvider)
        {
            return new TabControlNavigationService<StockFormViewModel>
            (
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<StockFormViewModel>(),
                () => serviceProvider.GetRequiredService<TabControlMenuViewModel>()
            );
        }
        private static INavigationService createPresentationModalNavigationService(IServiceProvider serviceProvider)
        {
            return new NavigationService<PresentationModalViewModel>
            (
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                () => serviceProvider.GetRequiredService<PresentationModalViewModel>()
            );
        }
        private static INavigationService createProductModalNavigationService(IServiceProvider serviceProvider)
        {
            return new NavigationService<ProductModalViewModel>
            (
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                () => serviceProvider.GetRequiredService<ProductModalViewModel>()
            );
        }
    }
}
