// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VillagerHelper.cs" company="">
//   
// </copyright>
// <summary>
//   The villager helper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.Processor.Helpers
{
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    ///     The villager helper.
    /// </summary>
    public class VillagerHelper
    {
        /// <summary>
        /// The get villager patient collection.
        /// </summary>
        /// <param name="hospitalizationCollection">
        /// The hospitalization collection.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        public IList<HospitalizationBase> GetVillagerCollection(IList<HospitalizationBase> hospitalizationCollection)
        {
            return hospitalizationCollection.Where(p => p.Villager == 1).ToList();
        }
    }
}