using UmbracoProject.PublishedContentModels.Models;
using UmbracoProject.ViewModels.Extensions;

namespace UmbracoProject.ViewModels.ViewModels.Elements
{
    public class OurPartnersSectionViewModel : ITabsBlockListViewModel
    {
        public OurPartnersSectionViewModel(OurPartnersSection model)
        {
            Title = model.Title;
            Items = model.Items.Select(item => item.AsViewModelExtension<ITabsBlockListViewModel>()).ToList();
        }

        public string Title { get; }
        public List<ITabsBlockListViewModel> Items { get; }
    }
}
