using UmbracoProject.PublishedContentModels.Models;
using UmbracoProject.ViewModels.Extensions;

namespace UmbracoProject.ViewModels.ViewModels.Elements
{
    public class BlockInfoSectionViewModel : ITabsBlockListViewModel
    {
        public BlockInfoSectionViewModel(BlockInfoSection model)
        {
            Items = model.Items.Select(item => item.AsViewModelExtension<ITabsBlockListViewModel>()).ToList();
            BackgroundColor = model.BackgroundColor;
        }
        public List<ITabsBlockListViewModel> Items { get; }
        public string BackgroundColor { get; }
    }
}
