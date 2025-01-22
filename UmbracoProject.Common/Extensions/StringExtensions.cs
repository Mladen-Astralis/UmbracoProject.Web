namespace UmbracoProject.Common.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveSuffix(this string source, string removeString, StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            if (string.IsNullOrWhiteSpace(removeString)) return source;

            if (source.EndsWith(removeString, comparisonType))
            {
                source = source.Remove(source.Length - removeString.Length);   
            }

            return source;
        }
    }
}
