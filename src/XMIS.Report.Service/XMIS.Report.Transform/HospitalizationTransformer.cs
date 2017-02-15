// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HospitalizationTransformer.cs" company="">
//   
// </copyright>
// <summary>
//   The hospitalization transformer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Transform
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    using XMIS.Report.Domain.Hospitalization;
    using XMIS.Report.Service.Contract;
    using XMIS.Report.Transform.Extensions;

    /// <summary>
    /// The hospitalization transformer.
    /// </summary>
    public class HospitalizationTransformer : IHospitalizationTransformer
    {
        /// <summary>
        /// The transformer pipeline.
        /// </summary>
        private List<IHospitalizationUnitTransformer> transformerPipeline = new List<IHospitalizationUnitTransformer>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HospitalizationTransformer"/> class.
        /// </summary>
        public HospitalizationTransformer()
        {
            this.transformerPipeline.Add(new PatientDescriptorTransformer());
        }

        /// <summary>
        /// The transform.
        /// </summary>
        /// <param name="dataRow">
        /// The data row.
        /// </param>
        /// <returns>
        /// The <see cref="HospitalizationBase"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        public HospitalizationBase Transform(DataRow dataRow)
        {
            try
            {
                HospitalizationBase hospitalization = new HospitalizationBase();

                hospitalization.HospitalizationId = dataRow["nib"].ToString().ToNumber();

                int enterMinutes = dataRow["pos_t"].ToString().ToMinutes();
                hospitalization.EnterDateTime = dataRow["pos_d"].ToString().ToDateTime(enterMinutes);

                int endMinutes = dataRow["out_t"].ToString().ToMinutes();
                hospitalization.EndDateTime = dataRow["out_d"].ToString().ToDateTime(endMinutes);

                hospitalization.AdmissionDepartmentId = dataRow["pos_kno"].ToString().ToNumber();
                hospitalization.DischargeDepartmentId = dataRow["out_kno"].ToString().ToNumber();

                if (dataRow["citycount"].ToString().ToNumber() != 1)
                {
                    hospitalization.Villager = 1;
                }

                hospitalization.IsWithMother = Convert.ToBoolean(dataRow["withmother"]);
                hospitalization.MedicalServiceResultId = dataRow["m_kres"].ToString().ToNumber();

                foreach (IHospitalizationUnitTransformer hospitalizationUnitTransformer in this.transformerPipeline)
                {
                    hospitalizationUnitTransformer.Transform(hospitalization, dataRow);
                }

                return hospitalization;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}