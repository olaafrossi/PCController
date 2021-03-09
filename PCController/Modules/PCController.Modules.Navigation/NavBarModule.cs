using PCController.Core;
using PCController.Modules.Navigation.Views;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PCController.Modules.Navigation
{
    public class NavBarModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public NavBarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.NavigationRegion, "NavBar");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavBar>();
        }
    }
}