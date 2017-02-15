// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DischargePatientFromTheBeginOfTheMonthOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The discharge patient from the begin of the month operation processor.
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
    /// The discharge patient from the begin of the month operation processor.
    /// </summary>
    public class DischargePatientFromTheBeginOfTheMonthOperationProcessor : IOperationProcessor
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
            // BeginOfTheMonth (початок місяця)
            /*Если отчет выгружается за 3.04.16
             * начало месяца 1.04.16 8:00:00 - 4.04.16 7:59:00
             */
            var beginOfTheMonth = new DateTime(startDateTime.Year, startDateTime.Month, 1);
            var fromDateTime = new DateTime(beginOfTheMonth.Year, beginOfTheMonth.Month, beginOfTheMonth.Day, 8, 0, 0);
            var toDateTime = new DateTime(startDateTime.Year, startDateTime.Month, startDateTime.Day, 7, 59, 0);

            return DischargePatientCommonOperationProcessor.GetDischargeCount(
                departmentId, 
                fromDateTime, 
                toDateTime, 
                hospitalizationBaseCollection);
        }
    }
}