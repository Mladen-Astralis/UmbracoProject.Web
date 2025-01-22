using UmbracoProject.PublishedContentModels.Models;
using UmbracoProject.ViewModels.Extensions;
using UmbracoProject.ViewModels.ViewModels.Elements;

namespace UmbracoProject.ViewModels.ViewModels.Pages
{
    public class HomePageViewModel
    {
        public HomePageViewModel(Home model)
        {
            Title = model.Title;
            Description = model.Description.ToHtmlString();
            ListElements = model.ListElements.Select(item => item.AsViewModel<IBlockListViewModel>()).ToList();
        }

        public string Title { get; }
        public string Description { get; }
        public List<IBlockListViewModel> ListElements { get; }



    }
}
