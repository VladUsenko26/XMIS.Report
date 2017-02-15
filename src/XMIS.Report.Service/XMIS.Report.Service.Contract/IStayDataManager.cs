// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStayDataManager.cs" company="">
//   
// </copyright>
// <summary>
//   The StayDataManager interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Service.Contract
{
    using System.Collections.Generic;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    /// The StayDataManager interface.
    /// </summary>
    public interface IStayDataManager
    {
        /// <summary>
        /// The get stay collection.
        /// </summary>
        /// <param name="condition">
        /// The condition.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        IList<StayBase> GetStayCollection(string condition);
    }
}