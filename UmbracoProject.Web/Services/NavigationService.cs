using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using UmbracoProject.PublishedContentModels.Models;
using UmbracoProject.ViewModels.Common;
using UmbracoProject.Web.Services.Interface;

namespace UmbracoProject.Web.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IUmbracoContextAccessor _contextAccessor;
        private readonly IUmbracoContext _umbracoContext;
        private readonly ILogger<NavigationService> _logger;

        public NavigationService(IUmbracoContextAccessor contextAccessor, ILogger<NavigationService> logger)
        {
            _contextAccessor = contextAccessor;
            _umbracoContext = _contextAccessor.GetRequiredUmbracoContext();
            _logger = logger;
        }
        public NavigationViewModel GetNavigation()
        {
            var home = _umbracoContext.Content.GetAtRoot().FirstOrDefault();
            var secoundLevel = home.Children;
            var homeUrl = home.Url();
            var maxLevel = ((Home)home).MaxLevel;

            var items = secoundLevel?.Select(item => GetNvigationItemViewModel(item, maxLevel)).ToList();

            return new NavigationViewModel { HomeUrl = homeUrl, MaxLevel = maxLevel,  NavigationItems = items };
        }

        private NavigationItemViewModel GetNvigationItemViewModel(IPublishedContent page, int maxLevel)
        {
            if (page != null)
            {
                var viewModel = new NavigationItemViewModel(page);
                if (page.Level < maxLevel)
                {
                    var subItems = page.Children?.Select(item => GetNvigationItemViewModel(item, maxLevel)).Where(item => !item.IsHiddenFromNavigation).ToList();
                    viewModel.NavigationSubItems = subItems;
                }
                return viewModel;
            }
            else
            {
                _logger.LogWarning("Navigation SubItems error! <NavigationService>");
            }
            return default;
            
        }
    }
}
