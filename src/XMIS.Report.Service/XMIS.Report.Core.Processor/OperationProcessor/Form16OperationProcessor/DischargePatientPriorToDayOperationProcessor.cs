// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DischargePatientPriorToDayOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The discharge patient prior to day operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.Processor.OperationProcessor.Form16OperationProcessor
{
    using System;
    using System.Collections.Generic;

    using XMIS.Report.Core.Processor.OperationProcessor.OperationProcessor.Common;
    using XMIS.Report.Domain.Hospitalization;
    using XMIS.Report.Service.Contract;

    /// <summary>
    ///     The discharge patient prior to day operation processor.
    /// </summary>
    public class DischargePatientPriorToDayOperationProcessor : IOperationProcessor
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
            return DischargePatientPriorToDayCommonOperationProcessor.GetDischargePatientPriorToDayCount(
                departmentId, 
                startDateTime, 
                endDateTime, 
                hospitalizationBaseCollection);
        }
    }
}