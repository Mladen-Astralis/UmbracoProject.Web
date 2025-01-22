using Umbraco.Cms.Core.Models.PublishedContent;
using UmbracoProject.PublishedContentModels.Models;

namespace UmbracoProject.ViewModels.Common
{
    public class FooterViewModel
    {
        public FooterViewModel(IFooter model)
        {
            FooterTitle = model.FooterTitle;
        }
        public string FooterTitle { get; set; }
    }
}
