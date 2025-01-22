using UmbracoProject.PublishedContentModels.Models;
using UmbracoProject.ViewModels.Extensions;

namespace UmbracoProject.ViewModels.ViewModels.Elements
{
    public class TabsComponentViewModel : ITabsBlockListViewModel
    {
        public TabsComponentViewModel(TabsComponent model)
        {
            SectionItems = model.SectionItems.Select(item => item.AsViewModelExtension<ITabsBlockListViewModel>()).ToList();
        }

        public List<ITabsBlockListViewModel> SectionItems { get; }    
    }
}
