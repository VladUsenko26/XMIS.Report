// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueryProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The QueryProcessor interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Contract
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    ///     The QueryProcessor interface.
    /// </summary>
    public interface IQueryProcessor
    {
        // TODO string condition, not param
        /// <summary>
        /// The get data for form.
        /// </summary>
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
        /// The <see cref="DataTable"/>.
        /// </returns>
        DataTable GetDataForForm(DateTime startDateTime, DateTime endDateTime, List<int> departmentIdCollection);
    }
}