// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The report processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.Common.Controllers.Operation
{
    using System;
    using System.Collections.Generic;

    using XMIS.Report.Service.Front.Client.Common.Context;

    /// <summary>
    ///     The report processor.
    /// </summary>
    public class ReportProcessor
    {
        /// <summary>
        /// The get report.
        /// </summary>
        /// <param name="reportName">
        /// The report name.
        /// </param>
        /// <param name="dateStart">
        /// The date start.
        /// </param>
        /// <param name="dateEnd">
        /// The date end.
        /// </param>
        /// <param name="departmentIdCollection">
        /// The department id collection.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetReport(
            string reportName, 
            DateTime dateStart, 
            DateTime dateEnd, 
            List<int> departmentIdCollection)
        {
            var getReportTask = ServiceContext.ReportProxy.Invoke<string>(
                "GetReport", 
                reportName, 
                dateStart, 
                dateEnd, 
                departmentIdCollection);

            getReportTask.Wait();
            var xml = getReportTask.Result;
            return xml;
        }
    }
}