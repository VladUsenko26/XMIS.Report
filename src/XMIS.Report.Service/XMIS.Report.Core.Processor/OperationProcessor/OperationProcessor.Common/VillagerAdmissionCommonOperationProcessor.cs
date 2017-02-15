// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VillagerAdmissionOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The villager admission operation processor.
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
    ///     The villager admission common operation processor.
    /// </summary>
    public static class VillagerAdmissionCommonOperationProcessor
    {
        /// <summary>
        ///     The villager helper.
        /// </summary>
        private static VillagerHelper villagerHelper;

        /// <summary>
        /// The get count.
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
        public static int GetVillagerAdmissionCount(
            int departmentId, 
            DateTime fromDateTime, 
            DateTime toDateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            /*  this.villagerHelper = new VillagerHelper();
              var villagerHospitalizationCollection =
                  this.villagerHelper.GetVillagerCollection(hospitalizationBaseCollection);

              return villagerHospitalizationCollection.Count(d => d.AdmissionDepartmentId == departmentId);
             * */
            var hospitalizationCollection =
                hospitalizationBaseCollection.Where(d => d.AdmissionDepartmentId == departmentId && d.Villager == 1);
            return hospitalizationCollection.Count(
                h => h.EnterDateTime >= fromDateTime && h.EnterDateTime <= toDateTime);
        }
    }
}