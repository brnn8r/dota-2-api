using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dota_2_api.ViewModels.Dota2.Errors
{
    /// <summary>
    /// UserError class.
    /// </summary>
    public partial class UserError
    {
        /// <summary>
        /// UserError constructor.
        /// </summary>
        /// <param name="errorCode">A unique code identifying the error.</param>
        /// <param name="userDescription">A description of the error. Suitable for displaying to a user.</param>
        /// <param name="developerDescription">A more detailed description of the error which should help a consumer developer diagnose the issue.</param>
        private UserError(string errorCode, string userDescription, string developerDescription)
        {
            this.ErrorCode = errorCode;
            this.UserDescription = userDescription;
            this.DeveloperDescription = developerDescription;
        }

        /// <summary>
        /// The error code associated with the user error. E.g. InvalidHero
        /// </summary>
        public string ErrorCode { get; private set; }
        /// <summary>
        /// A description of the error. Suitable for displaying to a user.
        /// </summary>
        public string UserDescription { get; private set; }
        /// <summary>
        /// A more detailed description of the error which should help a consumer developer diagnose the issue.
        /// </summary>
        public string DeveloperDescription { get; private set; }
    }
}