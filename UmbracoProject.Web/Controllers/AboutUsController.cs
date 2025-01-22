using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using UmbracoProject.PublishedContentModels.Models;
using UmbracoProject.ViewModels.ViewModels.Pages;

namespace UmbracoProject.Web.Controllers
{
    public class AboutUsController : RenderController
    {
        public AboutUsController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
        }

        public override IActionResult Index()
        {
            return View("aboutus", new AboutUsPageViewModel((AboutUs)CurrentPage));
        }
    }
}
