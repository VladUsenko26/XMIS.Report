// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DischargePatientPriorToDayCommonOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The discharge patient prior to day common operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Core.Processor.OperationProcessor.OperationProcessor.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    /// The discharge patient prior to day common operation processor.
    /// </summary>
    public static class DischargePatientPriorToDayCommonOperationProcessor
    {
        /// <summary>
        /// The get discharge patient prior to day count.
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
        public static int GetDischargePatientPriorToDayCount(
            int departmentId, 
            DateTime fromDateTime, 
            DateTime toDateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            var hospitalizationCollection =
                hospitalizationBaseCollection.Where(
                    h =>
                    h.DischargeDepartmentId == departmentId && h.EndDateTime.Subtract(h.EnterDateTime).Days == 0
                    && h.MedicalServiceResultId != 5);

            return hospitalizationCollection.Count(h => h.EndDateTime >= fromDateTime && h.EndDateTime <= toDateTime);
        }
    }
}