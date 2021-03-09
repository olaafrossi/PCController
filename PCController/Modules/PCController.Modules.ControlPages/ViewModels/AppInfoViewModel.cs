using PCController.Core.Mvvm;
using PCController.Services.Interfaces;
using Prism.Regions;

namespace PCController.Modules.ControlPages.ViewModels
{
    public class AppInfoViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public AppInfoViewModel(IRegionManager regionManager, IMessageService messageService) :
            base(regionManager)
        {
            Message = messageService.GetMessage();
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //do something
        }
    }
}
