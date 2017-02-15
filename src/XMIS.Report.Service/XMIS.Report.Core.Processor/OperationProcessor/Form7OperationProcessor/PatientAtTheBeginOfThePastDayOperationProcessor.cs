// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PatientAtTheBeginOfTheLastDayOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The patient at the begin of the last day operation processor.
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
    ///     The patient at the begin of the last day operation processor.
    /// </summary>
    public class PatientAtTheBeginOfThePastDayOperationProcessor : IOperationProcessor
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
            var pastDay = startDateTime.AddDays(-1);

            // TODO null for EndDateTime если пациент еще не выписан и находится в госпитале.
            return SickPatientCommonOperationProcessor.GetSickCount(
                departmentId, 
                pastDay, 
                hospitalizationBaseCollection);
        }
    }
}