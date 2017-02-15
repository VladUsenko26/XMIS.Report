// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DischargePatientCommonOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The discharge patient common operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Core.Processor.OperationProcessor.OperationProcessor.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    /// The discharge patient common operation processor.
    /// </summary>
    public static class DischargePatientCommonOperationProcessor
    {
        /// <summary>
        /// The get discharge count.
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
        public static int GetDischargeCount(
            int departmentId, 
            DateTime fromDateTime, 
            DateTime toDateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            var hospitalizationCollection =
                hospitalizationBaseCollection.Where(
                    d => d.DischargeDepartmentId == departmentId && d.MedicalServiceResultId != 5);

            return hospitalizationCollection.Count(h => h.EndDateTime >= fromDateTime && h.EndDateTime <= toDateTime);
        }
    }
}