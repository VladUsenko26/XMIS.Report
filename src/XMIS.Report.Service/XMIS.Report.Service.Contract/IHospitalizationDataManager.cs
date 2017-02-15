// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHospitalizationDataManager.cs" company="">
//   
// </copyright>
// <summary>
//   The HospitalizationDataManager interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Contract
{
    using System;
    using System.Collections.Generic;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    ///     The HospitalizationDataManager interface.
    /// </summary>
    public interface IHospitalizationDataManager
    {
        /// <summary>
        /// The get hospitalization collection.
        /// </summary>
        /// <param name="startDateTime">
        /// The start Date Time.
        /// </param>
        /// <param name="endDateTime">
        /// The end Date Time.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        IList<HospitalizationBase> GetHospitalizationCollection(DateTime startDateTime, DateTime endDateTime);
        IList<HospitalizationBase> GetHospitalizationCollection(string condition);
    }
}