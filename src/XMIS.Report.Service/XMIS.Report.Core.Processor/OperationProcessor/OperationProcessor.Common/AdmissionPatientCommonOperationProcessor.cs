// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdmissionDateOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The admission date operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.Processor.OperationProcessor.OperationProcessor.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    ///     The admission date operation processor.
    /// </summary>
    public static class AdmissionPatientCommonOperationProcessor
    {
        /// <summary>
        /// The get admission count.
        /// </summary>
        /// <param name="departmentId">
        /// The department id.
        /// </param>
        /// <param name="fromDateTime">
        /// The from date time.
        /// </param>
        /// <param name="toDateTime">
        /// The to date time.
        /// </param>
        /// <param name="hospitalizationBaseCollection">
        /// The hospitalization base collection.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GetAdmissionCount(
            int departmentId, 
            DateTime fromDateTime, 
            DateTime toDateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            var hospitalizationCollection =
                hospitalizationBaseCollection.Where(d => d.AdmissionDepartmentId == departmentId);

            return hospitalizationCollection.Count(
                h => h.EnterDateTime >= fromDateTime && h.EnterDateTime <= toDateTime);
        }
    }
}