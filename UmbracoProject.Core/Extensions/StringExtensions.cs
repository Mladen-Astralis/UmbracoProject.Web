using UmbracoProject.Common.Extensions;

namespace UmbracoProject.Core.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveViewModelSuffix(this string modelName)
        {
            return modelName.RemoveSuffix("ViewModel");
        }
    }
}
