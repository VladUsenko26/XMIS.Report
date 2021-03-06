﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AgeLessThan17AdmissionOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The age less than 17 admission operation processor.
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
    ///     The age less than 17 admission operation processor.
    /// </summary>
    public class AgeLessThan17AdmissionOperationProcessor : IOperationProcessor
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
            return AgeLessThan17AdmissionCommonOperationProcessor.GetAgeLessThan17AdmissionCount(
                departmentId, 
                startDateTime, 
                endDateTime, 
                startDateTime, 
                endDateTime, 
                hospitalizationBaseCollection);
        }
    }
}