using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dota_2_api.Services.Dota2
{
    public static class IEnumerableFilterExtensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> enumerable, string filter)
        {
            return enumerable.AsQueryable().Filter(filter);
        }
    }
}