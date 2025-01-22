using Umbraco.Cms.Core.Models;
using UmbracoProject.PublishedContentModels.Models;

namespace UmbracoProject.ViewModels.ViewModels.Elements
{
    public class TabsItemsViewModel : ITabsBlockListViewModel
    {
        public TabsItemsViewModel(TabsItems model)
        {
            NameForItem = model.NameForItem;
            Url = model.Link;
            InformationLink = model.InformationLink;
        }

        public string NameForItem { get; }
        public IEnumerable<Link> Url {  get; }
        public Link InformationLink { get; }
    }
}
