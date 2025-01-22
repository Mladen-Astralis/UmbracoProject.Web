using Microsoft.AspNetCore.Mvc;
using UmbracoProject.Web.Services.Interface;

namespace UmbracoProject.Web.ViewComponents
{
    public class NavigationViewComponent : ViewComponent
    {
        private readonly INavigationService _navigationService;
        public NavigationViewComponent(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _navigationService.GetNavigation();
            return View(model);

        }
    }
}