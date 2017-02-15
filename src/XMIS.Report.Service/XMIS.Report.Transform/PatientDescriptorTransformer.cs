// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PatientDescriptorTransformer.cs" company="">
//   
// </copyright>
// <summary>
//   The patient descriptor transformer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Transform
{
    using System;
    using System.Data;

    using XMIS.Report.Domain.Hospitalization;
    using XMIS.Report.Domain.Patient;
    using XMIS.Report.Domain.Person;
    using XMIS.Report.Service.Contract;
    using XMIS.Report.Transform.Extensions;

    /// <summary>
    /// The patient descriptor transformer.
    /// </summary>
    public class PatientDescriptorTransformer : IHospitalizationUnitTransformer
    {
        /// <summary>
        /// The transform.
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
        public HospitalizationBase Transform(HospitalizationBase hospitalization, DataRow dataRow)
        {
            hospitalization.Patient = this.GetPatient(hospitalization, dataRow);
            return hospitalization;
        }

        /// <summary>
        /// The get patient.
        /// </summary>
        /// <param name="hospitalization">
        /// The hospitalization.
        /// </param>
        /// <param name="dataRow">
        /// The data row.
        /// </param>
        /// <returns>
        /// The <see cref="PatientBase"/>.
        /// </returns>
        private PatientBase GetPatient(HospitalizationBase hospitalization, DataRow dataRow)
        {
            var personIdentityInfo = new PersonIdentityInfoBase();
            personIdentityInfo.DateOfBirth = dataRow["pac_born"].ToString().ToDateTime(0);
            personIdentityInfo.FirstName = dataRow["pacname"].ToString();
            personIdentityInfo.MiddleName = dataRow["pacsurname"].ToString();
            personIdentityInfo.LastName = dataRow["pacfam"].ToString();
            personIdentityInfo.SexId = Convert.ToInt32(dataRow["pac_sex"]);

            var person = new PersonBase { PersonIdentityInfo = personIdentityInfo };
            var patient = new PatientBase { Person = person };

            return patient;
        }
    }
}