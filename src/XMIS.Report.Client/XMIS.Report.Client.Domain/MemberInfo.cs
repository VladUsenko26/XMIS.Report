// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MemberInfo.cs" company="">
//   
// </copyright>
// <summary>
//   The member info.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Client.Domain
{
    using System.Collections.Generic;

    /// <summary>
    ///     The member info.
    /// </summary>
    public class MemberInfo
    {
        /// <summary>
        /// Gets or sets the fault info collection.
        /// </summary>
        public List<string> FaultInfoCollection { get; set; }

        /// <summary>
        ///     Gets or sets the login.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        ///     Gets or sets the password.
        /// </summary>
        public string Password { get; set; }
    }
}