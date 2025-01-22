using Umbraco.Cms.Core.Models;
using UmbracoProject.PublishedContentModels.Models;

namespace UmbracoProject.ViewModels.ViewModels.Elements
{
    public class OurPartnersViewModel : ITabsBlockListViewModel
    {
        public OurPartnersViewModel(OurPartners model)
        {
            Url = model.Link;
            Image = model.Image;
        }
        public MediaWithCrops Image { get; }
        public Link Url { get; }
    }
}
