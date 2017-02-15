// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportInfo.cs" company="">
//   
// </copyright>
// <summary>
//   The report info.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Client.Domain
{
    /// <summary>
    ///     The report info.
    /// </summary>
    public class ReportInfo
    {
        /// <summary>
        ///     Gets or sets the report name.
        /// </summary>
        public string ReportName { get; set; }

        /// <summary>
        ///     Gets or sets the report id.
        /// </summary>
        public int ReportId { get; set; }

        /// <summary>
        ///     Gets or sets the report display name.
        /// </summary>
        public string ReportDisplayName { get; set; }
    }
}