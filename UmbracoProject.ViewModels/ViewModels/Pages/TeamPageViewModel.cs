using UmbracoProject.PublishedContentModels.Models;
using UmbracoProject.ViewModels.Extensions;
using UmbracoProject.ViewModels.ViewModels.Elements;

namespace UmbracoProject.ViewModels.ViewModels.Pages
{
    public class TeamPageViewModel
    {
        public TeamPageViewModel(Team model)
        {
            Title = model.Title;
            Description = model.Description.ToHtmlString();
            Elements = model.Elements.Select(item => item.AsViewModel<IBlockListViewModel>()).ToList();
        }

        public string Title { get; }
        public string Description { get; }
        public List<IBlockListViewModel> Elements { get; }

    }
}
