﻿namespace UmbracoProject.Web.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool HasValue<T>(this IEnumerable<T> items)
            => items != null && items.Any();
    }
}
