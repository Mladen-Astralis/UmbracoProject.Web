using Umbraco.Cms.Core.Models;
using UmbracoProject.PublishedContentModels.Models;

namespace UmbracoProject.ViewModels.ViewModels.Elements
{
    public class PageBanerViewModel : ITabsBlockListViewModel
    {
        public PageBanerViewModel(PageBaner model)
        {
            BanerImage = model.BanerImage;
            AltTitle = model.AltTitle;
        }

        public MediaWithCrops BanerImage { get; }
        public string AltTitle { get; }  
    }
}
