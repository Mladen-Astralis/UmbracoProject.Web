using UmbracoProject.PublishedContentModels.Models;
using UmbracoProject.ViewModels.Extensions;

namespace UmbracoProject.ViewModels.ViewModels.Elements
{
    public class TabsLinkSectionViewModel : ITabsBlockListViewModel
    {
        public TabsLinkSectionViewModel(TabsLinkSection model)
        {
            Title = model.Title;
            TestName = model.TestName.Select(item => item.AsViewModelExtension<ITabsBlockListViewModel>()).ToList();
        }
        public string Title { get; }
        public List<ITabsBlockListViewModel> TestName { get; }
    }
}
