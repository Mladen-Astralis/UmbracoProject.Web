using UmbracoProject.PublishedContentModels.Models;
using UmbracoProject.ViewModels.Extensions;
using UmbracoProject.ViewModels.ViewModels.Elements;

namespace UmbracoProject.ViewModels.ViewModels.Pages
{
    public class NewHomePageViewModel
    {
        public NewHomePageViewModel(NewHome model)
        
        {
            MainContent = model.MainContent.Select(item => item.AsViewModelExtension<ITabsBlockListViewModel>()).ToList();
        }

        public List<ITabsBlockListViewModel> MainContent { get; }
    }
}
