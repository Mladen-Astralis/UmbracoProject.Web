using Umbraco.Cms.Core.Models;
using UmbracoProject.PublishedContentModels.Models;

namespace UmbracoProject.ViewModels.ViewModels.Elements
{
    public class ContentTextSectionViewModel : ITabsBlockListViewModel
    {
        public ContentTextSectionViewModel(ContentTextSection model)
        {
            Title = model.Title;
            Description = model.Description.ToHtmlString();
            BackgroundColor = model.BackgroundColor;
            Url = model.Link;
            BtnTitleColor = ((IButtonProperty)model).TitleColor;
            BtnBackgroundColor = ((IButtonProperty)model).BtnBackgroundColor;
        }

        public string Title { get; }
        public string Description { get; }
        public Link Url { get; }
        public string BackgroundColor { get; }

        public string BtnTitleColor { get; }
        public string BtnBackgroundColor { get; }
    }
}
