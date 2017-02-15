// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IsWithMotherOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The is with mother operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.Processor.OperationProcessor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;
    using XMIS.Report.Service.Contract;

    /// <summary>
    ///     The is with mother operation processor.
    /// </summary>
    public class IsWithMotherOperationProcessor : IOperationProcessor
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
        public int GetCount(
            int departmentId, 
            DateTime startDateTime, 
            DateTime endDateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            // TODO AdmissionDepartmentId OR DischargeDepartmentId in condition?
            // TODO IsWithMother 0 OR 1 
            return
                hospitalizationBaseCollection.Count(d => d.AdmissionDepartmentId == departmentId && d.IsWithMother == true);
        }
    }
}