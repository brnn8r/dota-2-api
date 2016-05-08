using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dota_2_api.Services.Dota2
{
    public static class IEnumerableSortingExtensions
    {
        public static IEnumerable<T> Sort<T>(this IEnumerable<T> enumerable, string sort)
        {
            return enumerable.AsQueryable().Sort(sort);
        }
    }
}