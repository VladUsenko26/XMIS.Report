// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeathOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The death operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.Processor.OperationProcessor.OperationProcessor.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    ///     The death common operation processor.
    /// </summary>
    public static class DeathCommonOperationProcessor
    {
        /// <summary>
        /// The get death count.
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
        public static int GetDeathCount(
            int departmentId, 
            DateTime fromDateTime, 
            DateTime toDateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            var hospitalizationCollection =
                hospitalizationBaseCollection.Where(
                    d => d.MedicalServiceResultId == 5 && d.AdmissionDepartmentId == departmentId);
            return hospitalizationCollection.Count(h => h.EnterDateTime >= fromDateTime && h.EndDateTime <= toDateTime);
        }
    }
}