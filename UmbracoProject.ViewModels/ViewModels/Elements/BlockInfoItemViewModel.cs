using UmbracoProject.PublishedContentModels.Models;

namespace UmbracoProject.ViewModels.ViewModels.Elements
{
    public class BlockInfoItemViewModel : ITabsBlockListViewModel
    {
        public BlockInfoItemViewModel(BlockInfoItem model)
        {
            Title = model.Title;
            Subtitle = model.Subtitle;
            Description = model.Description.ToHtmlString();
        }
        public string Title { get; }
        public string Subtitle { get; }
        public string Description { get; }
    }
}
