using System.Reflection;
using Umbraco.Cms.Core.Models.Blocks;
using UmbracoProject.PublishedContentModels.Models;
using UmbracoProject.ViewModels.ViewModels.Elements;

namespace UmbracoProject.ViewModels.Extensions
{
    public static class ViewModelExtensions
    {
        public static TeamElementsViewModel ToViewModel(this BlockListItem item) => (item != null && item.Content is TeamElements element) ? new TeamElementsViewModel(element) : default;
        public static List<TeamElementsViewModel> ToViewModel(this BlockListModel items) => items.Select(ToViewModel).ToList();

        public static T AsViewModel<T>(this BlockListItem blockList, string classSuffix = "ViewModel") where T : IBlockListViewModel
        {
            if (blockList == null) return default(T);
            var content = blockList.Content;
            Type baseType = typeof(T);
            string modelTypeName = $"{baseType.Namespace}.{content.GetType().Name}{classSuffix}";

            return (T)Activator.CreateInstance(Assembly.GetAssembly(baseType).GetType(modelTypeName), content);
       
        }

        public static T AsViewModelExtension<T>(this BlockListItem blockList, string classSuffix = "ViewModel") where T : ITabsBlockListViewModel
        {
            if (blockList == null) return default(T);
            var content = blockList.Content;
            Type baseType = typeof(T);
            string modelTypeName = $"{baseType.Namespace}.{content.GetType().Name}{classSuffix}";

            return (T)Activator.CreateInstance(Assembly.GetAssembly(baseType).GetType(modelTypeName), content);

        }

    }
}
