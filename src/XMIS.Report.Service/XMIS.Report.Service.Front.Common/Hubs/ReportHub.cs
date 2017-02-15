// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportHub.cs" company="">
//   
// </copyright>
// <summary>
//   The report hub.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Common.Hubs
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNet.SignalR;
    using Microsoft.AspNet.SignalR.Hubs;

    using XMIS.Report.Domain;

    /// <summary>
    ///     The report hub.
    /// </summary>
    [HubName("reportHub")]
    public class ReportHub : Hub
    {
        /// <summary>
        ///     The report list manager.
        /// </summary>
        private ReportListManager reportListManager;

        /// <summary>
        ///     The report processor manager.
        /// </summary>
        private ReportProcessorManager reportProcessorManager;

        /// <summary>
        /// The get report.
        /// </summary>
        /// <param name="reportName">
        /// The report name.
        /// </param>
        /// <param name="startDateTime">
        /// The start date time.
        /// </param>
        /// <param name="endDateTime">
        /// The end date time.
        /// </param>
        /// <param name="departmentIdCollection">
        /// The department id collection.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<string> GetReport(
            string reportName, 
            DateTime startDateTime, 
            DateTime endDateTime, 
            List<int> departmentIdCollection)
        {
            return await Task.Run(
                () =>
                    {
                        this.reportProcessorManager = new ReportProcessorManager();
                        var xml = this.reportProcessorManager.GetFillXmlReport(
                            reportName, 
                            startDateTime, 
                            endDateTime, 
                            departmentIdCollection);
                        return xml;
                    });
        }

        /// <summary>
        ///     The get report collection.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public async Task<List<ReportInfo>> GetReportCollection()
        {
            return await Task.Run(
                () =>
                    {
                        this.reportListManager = new ReportListManager();
                        var reportList = this.reportListManager.GetReportCollection();
                        return reportList;
                    });
        }
    }
}