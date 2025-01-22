using Umbraco.Cms.Core.Models;
using UmbracoProject.PublishedContentModels.Models;

namespace UmbracoProject.ViewModels.ViewModels.Elements
{
    public class ImageElementViewModel : IBlockListViewModel
    {
        public ImageElementViewModel(ImageElement model)
        {
            Title = model.Title;
            Image = model.Image;
        }
        public string Title { get; }
        public MediaWithCrops Image { get; }
    }
}
