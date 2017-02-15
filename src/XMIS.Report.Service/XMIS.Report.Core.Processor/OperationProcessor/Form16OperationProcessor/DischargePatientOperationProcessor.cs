// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DischargeDateOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The discharge date operation processor.
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
    ///     The discharge date operation processor.
    /// </summary>
    public class DischargePatientOperationProcessor : IOperationProcessor
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
        /// Number of discharged patients according to the department
        /// </returns>
        public int GetCount(
            int departmentId, 
            DateTime startDateTime, 
            DateTime endDateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            // TODO нужно ли условие d.MedicalServiceResultId != 5
            return DischargePatientCommonOperationProcessor.GetDischargeCount(
                departmentId, 
                startDateTime, 
                endDateTime, 
                hospitalizationBaseCollection);
        }
    }
}