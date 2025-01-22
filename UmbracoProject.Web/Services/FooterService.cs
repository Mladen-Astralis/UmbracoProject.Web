using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Persistence.EFCore;
using Umbraco.Cms.Web.Common.UmbracoContext;
using UmbracoProject.PublishedContentModels.Models;
using UmbracoProject.ViewModels.Common;
using UmbracoProject.Web.Services.Interface;

namespace UmbracoProject.Web.Services
{
    public class FooterService : IFooterService
    {
        private readonly IUmbracoContextAccessor _umbracoAccessor;
        private readonly IUmbracoContext _umbracoContext;

        public FooterService(IUmbracoContextAccessor umbracoAccessor)
        {
            _umbracoAccessor = umbracoAccessor;
            _umbracoContext = _umbracoAccessor.GetRequiredUmbracoContext();
        }
        public FooterViewModel GetContent()
        {
            var home = _umbracoContext.Content.GetAtRoot().FirstOrDefault();
            var footer = (IFooter)home;
            return new FooterViewModel(footer);
        }
    }
}
