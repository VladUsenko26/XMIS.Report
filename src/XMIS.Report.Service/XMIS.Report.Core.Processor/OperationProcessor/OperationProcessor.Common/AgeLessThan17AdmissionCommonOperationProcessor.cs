// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AgeLessThan17OperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The age less than 17 operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.Processor.OperationProcessor.OperationProcessor.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Core.Processor.Helpers;
    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    ///     The age less than 17 admission common operation processor.
    /// </summary>
    public class AgeLessThan17AdmissionCommonOperationProcessor
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
        /// <param name="fromDateTime">
        /// The from Date Time.
        /// </param>
        /// <param name="toDateTime">
        /// The to Date Time.
        /// </param>
        /// <param name="hospitalizationBaseCollection">
        /// The hospitalization base collection.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GetAgeLessThan17AdmissionCount(
            int departmentId, 
            DateTime startDateTime, 
            DateTime endDateTime, 
            DateTime fromDateTime, 
            DateTime toDateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            var ageOperationProcessor = new AgeOperationHelper();

            var hospitalizationCollection =
                hospitalizationBaseCollection.Where(
                    h =>
                    h.AdmissionDepartmentId == departmentId && h.EnterDateTime >= fromDateTime
                    && h.EndDateTime <= toDateTime).ToList();

            return ageOperationProcessor.GetCountPatientAgeLessThan(17, startDateTime, hospitalizationCollection);
        }
    }
}