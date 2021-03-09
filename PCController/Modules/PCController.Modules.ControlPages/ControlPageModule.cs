using PCController.Core;
using PCController.Modules.ControlPages.Views;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PCController.Modules.ControlPages
{
    public class ControlPageModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ControlPageModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "AppInfo");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<AppInfo>();
        }
    }
}
