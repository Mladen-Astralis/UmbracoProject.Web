using UmbracoProject.Web.Services;
using UmbracoProject.Web.Services.Interface;

namespace UmbracoProject.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<INavigationService, NavigationService>();
        }
    }
}
