using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dota_2_api.Services.Dota2
{
    public static class IQueryableFilterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryable"></param>
        /// <param name="filter">Example "Type:Strength,StrengthGain>20"</param>
        /// <returns></returns>
        public static IQueryable<T> Filter<T>(this IQueryable<T> queryable, string filter)
        {
            var properties = typeof(T).GetProperties();

            var individualFilters = filter.Split(',');

            foreach(var individualFilter in individualFilters)
            {

                //Look for equality
                if(individualFilter.Contains(":"))
                {
                    var filterParts = individualFilter.Split(':');

                    var field = filterParts.First();
                    var value = filterParts.Last();

                    var relatedProperty = properties.SingleOrDefault(p => String.Equals(p.Name, field, StringComparison.OrdinalIgnoreCase));

                    if (relatedProperty == null) continue;

                    queryable = queryable.Where(item => string.Equals(value, Convert.ToString(relatedProperty.GetValue(item)), StringComparison.OrdinalIgnoreCase));
                }                
                //Look for given field with values greater than this
                else if(individualFilter.Contains(">"))
                {

                }
                //Look for given field with values less than this
                else if (individualFilter.Contains("<"))
                {

                }
            }

            return queryable;
        }
    }
}