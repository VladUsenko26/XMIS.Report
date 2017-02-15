// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DischargePatientPriorToDayForThePastDayOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The discharge patient prior to day for the past day operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Core.Processor.OperationProcessor.Form7OperationProcessor
{
    using System;
    using System.Collections.Generic;

    using XMIS.Report.Core.Processor.OperationProcessor.OperationProcessor.Common;
    using XMIS.Report.Domain.Hospitalization;
    using XMIS.Report.Service.Contract;

    /// <summary>
    /// The discharge patient prior to day for the past day operation processor.
    /// </summary>
    public class DischargePatientPriorToDayForThePastDayOperationProcessor : IOperationProcessor
    {
        /// <summary>
        /// The get count.
        /// </summary>
        /// <param name="departmentId">
        /// The department id.
        /// </param>
        /// <param name="startDateTime">
        /// The start date time.
        /// </param>
        /// <param name="endDateTime">
        /// The end date time.
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
            // Past day (минула доба)
            var pastDay = startDateTime.AddDays(-1);
            var fromDateTime = new DateTime(pastDay.Year, pastDay.Month, pastDay.Day, 8, 0, 0);
            var toDateTime = new DateTime(startDateTime.Year, startDateTime.Month, startDateTime.Day, 7, 59, 0);

            return DischargePatientPriorToDayCommonOperationProcessor.GetDischargePatientPriorToDayCount(
                departmentId, 
                fromDateTime, 
                toDateTime, 
                hospitalizationBaseCollection);
        }
    }
}