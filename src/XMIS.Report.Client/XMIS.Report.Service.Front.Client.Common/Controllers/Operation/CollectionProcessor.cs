// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollectionProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The collection processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.Common.Controllers.Operation
{
    using System.Collections.Generic;

    using XMIS.Report.Client.Domain;
    using XMIS.Report.Service.Front.Client.Common.Context;

    /// <summary>
    ///     The collection processor.
    /// </summary>
    public class CollectionProcessor
    {
        /// <summary>
        ///     The get report collection.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<ReportInfo> GetReportCollection()
        {
            var getReportTask = ServiceContext.ReportProxy.Invoke<List<ReportInfo>>("GetReportCollection");

            getReportTask.Wait();
            var reportCollection = getReportTask.Result;
            return reportCollection;
        }

        /// <summary>
        ///     The get department collection.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<DepartmentInfo> GetDepartmentCollection()
        {
            var getDepartmentTask = ServiceContext.ReportProxy.Invoke<List<DepartmentInfo>>("GetDepartmentCollection");
            getDepartmentTask.Wait();
            var departmentCollection = getDepartmentTask.Result;
            return departmentCollection;
        }
    }
}