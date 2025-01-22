using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using UmbracoProject.ViewModels.ViewModels.Elements;

namespace UmbracoProject.Web.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static async Task<IHtmlContent> RenderBlockListPartial(this IHtmlHelper htmlHelper, IBlockListViewModel model)
        {
            string partialName = model.GetType().Name.Replace("ViewModel", string.Empty);
            return await htmlHelper.PartialAsync($"/Views/Partials/TeamBlockList/_{partialName}.cshtml", model);
        }

        public static async Task<IHtmlContent> RenderContentBlockListPartial(this IHtmlHelper htmlHelper, ITabsBlockListViewModel model)
        {
            string partialName = model.GetType().Name.Replace("ViewModel", string.Empty);
            return await htmlHelper.PartialAsync($"/Views/Partials/HomePageContent/_{partialName}.cshtml", model);
        }

    }
}