using Umbraco.Cms.Core.Services;
using UmbracoProject.Web;
using UmbracoProject.Web.Services.Interface;
using UmbracoProject.Web.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.CreateUmbracoBuilder()
.AddBackOffice()
.AddWebsite()
    .AddDeliveryApi()
    .AddComposers()
    .Build();

builder.Services.AddTransient<INavigationService, NavigationService>();
builder.Services.AddTransient<IFooterService, FooterService>();

WebApplication app = builder.Build();

await app.BootUmbracoAsync();

app.UseHttpsRedirection();

app.UseUmbraco()
    .WithMiddleware(u =>
    {
        u.UseBackOffice();
        u.UseWebsite();
    })
    .WithEndpoints(u =>
    {
        u.UseInstallerEndpoints();
        u.UseBackOfficeEndpoints();
        u.UseWebsiteEndpoints();
    });

await app.RunAsync();
