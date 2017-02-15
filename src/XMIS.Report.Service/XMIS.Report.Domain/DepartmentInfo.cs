// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DepartmentInfo.cs" company="">
//   
// </copyright>
// <summary>
//   The department info.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Domain
{
    /// <summary>
    ///     The department info.
    /// </summary>
    public class DepartmentInfo
    {
        /// <summary>
        ///     Gets or sets the department name.
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        ///     Gets or sets the department id.
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the owner id.
        /// </summary>
        public int OwnerId { get; set; }
    }
}