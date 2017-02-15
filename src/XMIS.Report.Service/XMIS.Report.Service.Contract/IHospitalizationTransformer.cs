// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHospitalizationTransformer.cs" company="">
//   
// </copyright>
// <summary>
//   The HospitalizationTransformer interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Service.Contract
{
    using System.Data;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    /// The HospitalizationTransformer interface.
    /// </summary>
    public interface IHospitalizationTransformer
    {
        /// <summary>
        /// The transform.
        /// </summary>
        /// <param name="dataRow">
        /// The data row.
        /// </param>
        /// <returns>
        /// The <see cref="HospitalizationBase"/>.
        /// </returns>
        HospitalizationBase Transform(DataRow dataRow);
    }
}