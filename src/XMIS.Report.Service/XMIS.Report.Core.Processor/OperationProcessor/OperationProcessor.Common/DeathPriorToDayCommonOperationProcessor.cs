// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeathPriorToDayOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The death prior to day operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.Processor.OperationProcessor.OperationProcessor.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    ///     The death prior to day.
    /// </summary>
    public static class DeathPriorToDayCommonOperationProcessor
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
                    d =>
                    d.MedicalServiceResultId == 5 && d.AdmissionDepartmentId == departmentId
                    && d.EndDateTime.Subtract(d.EnterDateTime).Days == 0).ToList();

            return hospitalizationCollection.Count(h => h.EnterDateTime >= fromDateTime && h.EndDateTime <= toDateTime);
        }
    }
}