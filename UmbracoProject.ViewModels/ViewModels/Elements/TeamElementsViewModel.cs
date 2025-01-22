using Umbraco.Cms.Core.Models;
using UmbracoProject.PublishedContentModels.Models;

namespace UmbracoProject.ViewModels.ViewModels.Elements
{
    public class TeamElementsViewModel : IBlockListViewModel
    {
        public TeamElementsViewModel(TeamElements model)
        {
            Name = model.TeamName;
            Description = model.Description.ToHtmlString();
            TeamImage = model.TeamImage;
            ShowImage = model.ShowImage;
        }

        public string Name { get; }
        public string Description { get;}
        public MediaWithCrops TeamImage { get;}
        public bool ShowImage { get; }

    }
}
