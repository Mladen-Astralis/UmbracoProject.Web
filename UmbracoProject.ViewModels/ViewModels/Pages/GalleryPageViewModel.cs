using Umbraco.Cms.Core.Models;
using UmbracoProject.PublishedContentModels.Models;

namespace UmbracoProject.ViewModels.ViewModels.Pages
{
    public class GalleryPageViewModel
    {
        public GalleryPageViewModel(Gallery model)
        {
            Images = model.Images;
        }
        public IEnumerable<MediaWithCrops> Images { get; }
    }
}
