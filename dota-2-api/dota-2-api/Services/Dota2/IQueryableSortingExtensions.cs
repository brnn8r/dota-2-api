using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Web;

namespace dota_2_api.Services.Dota2
{
    public static class IQueryableSortingExtensions
    {
        public static IQueryable<T> Sort<T>(this IQueryable<T> queryable, string sort)
        {
            if(queryable == null)
            {
                throw new ArgumentNullException("queryable");
            }

            if(string.IsNullOrWhiteSpace(sort))
            {
                return queryable;
            }

            var sortParams = sort.Split(',');

            var sortExpression = new List<string>();
            foreach(var sortParam in sortParams)
            {
                if(sortParam.StartsWith("-"))
                {
                    sortExpression.Add(sortParam.Remove(0, 1) + " descending");
                }
                else
                {
                    sortExpression.Add(sortParam);
                }
            }

            if(!sortExpression.Any())
            {
                return queryable;
            }

            queryable = queryable.OrderBy(String.Join(",", sortExpression));
            return queryable;
        }
    }
}