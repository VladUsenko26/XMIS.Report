// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHospitalizationUnitTransformer.cs" company="">
//   
// </copyright>
// <summary>
//   The HospitalizationUnitTransformer interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Service.Contract
{
    using System.Data;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    /// The HospitalizationUnitTransformer interface.
    /// </summary>
    public interface IHospitalizationUnitTransformer
    {
        /// <summary>
        /// Updates service descriptor objects by adding an information to one of its units.
        /// </summary>
        /// <param name="hospitalization">
        /// The hospitalization.
        /// </param>
        /// <param name="dataRow">
        /// The data row.
        /// </param>
        /// <returns>
        /// The <see cref="HospitalizationBase"/>.
        /// </returns>
        HospitalizationBase Transform(HospitalizationBase hospitalization, DataRow dataRow);
    }
}