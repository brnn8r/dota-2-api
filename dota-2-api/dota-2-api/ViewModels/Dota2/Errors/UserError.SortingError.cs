using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dota_2_api.ViewModels.Dota2.Errors
{
    public partial class UserError
    {
        /// <summary>
        /// Errors related to sorting.
        /// </summary>
        public class SortingError
        {
            /// <summary>
            /// Indicates that an invalid field has been selected to sort on sort.
            /// </summary>
            /// <param name="invalidSortParameter">The name of the field provided to sort on.</param>
            /// <returns>A new UserError</returns>
            public static UserError InvalidSortParameter(string invalidSortParameter)
            {                
                return new UserError("InvalidSortParameter", String.Format("Invalid sort parameter {0}", invalidSortParameter), String.Format("Invalid sort parameter {0}", invalidSortParameter));
            }
        }
    }
}