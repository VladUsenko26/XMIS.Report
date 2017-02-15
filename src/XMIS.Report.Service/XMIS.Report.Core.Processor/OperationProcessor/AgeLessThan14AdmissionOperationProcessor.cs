// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AgeLessThan14OperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The age less than 14 operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.Processor.OperationProcessor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Core.Processor.Helpers;
    using XMIS.Report.Domain.Hospitalization;
    using XMIS.Report.Service.Contract;

    /// <summary>
    ///     The age less than 14 operation processor.
    /// </summary>
    public class AgeLessThan14AdmissionOperationProcessor : IOperationProcessor
    {
        /// <summary>
        ///     The age operation processor.
        /// </summary>
        private AgeOperationHelper ageOperationProcessor;

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
            this.ageOperationProcessor = new AgeOperationHelper();

            IList<HospitalizationBase> hospitalizationCollection =
                hospitalizationBaseCollection.Where(h => h.AdmissionDepartmentId == departmentId).ToList();

            return this.ageOperationProcessor.GetCountPatientAgeLessThan(14, startDateTime, hospitalizationCollection);
        }
    }
}