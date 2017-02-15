// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AgeOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The age operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.Processor.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    ///     The age operation processor.
    /// </summary>
    public class AgeOperationHelper
    {
        /// <summary>
        /// The get age.
        /// </summary>
        /// <param name="dateOfBirth">
        /// The date of birth.
        /// </param>
        /// <param name="dateTime">
        /// The date time.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private int GetAge(DateTime dateOfBirth, DateTime dateTime)
        {
            var age = dateTime.Year - dateOfBirth.Year;

            if (dateTime.Month < dateOfBirth.Month
                || (dateTime.Month == dateOfBirth.Month && dateTime.Day < dateOfBirth.Day))
            {
                age--;
            }

            return age;
        }

        // TODO возраст на момент поступления 
        /// <summary>
        /// The get count patient age less than.
        /// </summary>
        /// <param name="lessThan">
        /// The less than.
        /// </param>
        /// <param name="dateTime">
        /// The date time.
        /// </param>
        /// <param name="hospitalizationBaseCollection">
        /// The hospitalization base collection.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int GetCountPatientAgeLessThan(
            int lessThan, 
            DateTime dateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            return
                hospitalizationBaseCollection.Select(
                    hospitalizationBase => hospitalizationBase.Patient.Person.PersonIdentityInfo.DateOfBirth)
                    .Select(dateOfBirth => this.GetAge(dateOfBirth, dateTime))
                    .Count(age => age <= lessThan);

            /*
                        foreach (HospitalizationBase hospitalizationBase in hospitalizationBaseCollection)
            {
                DateTime dateOfBirth = hospitalizationBase.Patient.Person.PersonIdentityInfo.DateOfBirth;
                int age = this.GetAge(dateOfBirth, dateTime);
                if (age < lessThan)
                {
                    count ++;
                }
            }
            */
        }
    }
}