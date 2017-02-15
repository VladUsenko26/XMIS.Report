// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The OperationProcessor interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Contract
{
    using System;
    using System.Collections.Generic;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    ///     The OperationProcessor interface.
    /// </summary>
    public interface IOperationProcessor
    {
        /// <summary>
        /// The get count.
        /// </summary>
        /// <param name="departmentId">
        /// The department id.
        /// </param>
        /// <param name="startDateTime">
        /// The start Date Time.
        /// </param>
        /// <param name="endDateTime">
        /// The end Date Time.
        /// </param>
        /// <param name="hospitalizationBaseCollection">
        /// The hospitalization base collection.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int GetCount(
            int departmentId, 
            DateTime startDateTime, 
            DateTime endDateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection);
    }
}