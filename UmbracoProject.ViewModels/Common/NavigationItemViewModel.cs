using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;
using UmbracoProject.PublishedContentModels.Models;

namespace UmbracoProject.ViewModels.Common
{
    public class NavigationItemViewModel
    {
        public NavigationItemViewModel(IPublishedContent model)
        {
            NavigationTitle = ((IPage)model).NavigationTitle;
            NavigationUrl = model.Url();
            IsHiddenFromNavigation = ((IPage)model).IsHiddenFromNavigation;
            
        }
        public int Level { get; set; }
        public bool IsHiddenFromNavigation { get; set; }
        public string NavigationTitle { get; set; }
        public string NavigationUrl { get; set; }
        public List<NavigationItemViewModel> NavigationSubItems { get; set; }
    }
}
