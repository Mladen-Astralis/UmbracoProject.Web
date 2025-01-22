using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;
using UmbracoProject.PublishedContentModels.Models;
using UmbracoProject.Web.Services;
using UmbracoProject.Web.Services.Interface;

namespace UmbracoProject.Web.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly IFooterService _footerService;
        public FooterViewComponent(IFooterService footerService)
        {
            _footerService = footerService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _footerService.GetContent();
            return View(model);
        }
    }
}
