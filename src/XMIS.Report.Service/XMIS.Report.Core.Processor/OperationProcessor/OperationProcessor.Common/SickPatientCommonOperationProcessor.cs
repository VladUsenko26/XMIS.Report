// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SickPatientCommonOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The sick patient common operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.Processor.OperationProcessor.OperationProcessor.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    ///     The sick patient common operation processor.
    /// </summary>
    public static class SickPatientCommonOperationProcessor
    {
        /// <summary>
        /// The get sick count.
        /// </summary>
        /// <param name="departmentId">
        /// The department id.
        /// </param>
        /// <param name="beginDateTime">
        /// The begin date time.
        /// </param>
        /// <param name="hospitalizationBaseCollection">
        /// The hospitalization base collection.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GetSickCount(
            int departmentId, 
            DateTime beginDateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            // TODO null for EndDateTime если пациент еще не выписан и находится в госпитале.
            return
                hospitalizationBaseCollection.Count(
                    h =>
                    h.EnterDateTime <= beginDateTime && (h.EndDateTime >= beginDateTime || h.EndDateTime == null)
                    && h.AdmissionDepartmentId == departmentId);
        }
    }
}