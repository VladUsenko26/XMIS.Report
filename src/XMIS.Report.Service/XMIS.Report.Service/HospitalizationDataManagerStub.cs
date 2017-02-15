// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HospitalizationDataManager.cs" company="">
//   
// </copyright> 
// <summary>
//   The hospitalization data manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;
    using XMIS.Report.Domain.Patient;
    using XMIS.Report.Domain.Person;
    using XMIS.Report.Service.Contract;

    /// <summary>
    ///     The hospitalization data manager.
    /// </summary>
    public class HospitalizationDataManagerStub : IHospitalizationDataManager
    {
        /// <summary>
        /// The hospitalization stub collection.
        /// </summary>
        private readonly IList<HospitalizationBase> hospitalizationStubCollection;

        /// <summary>
        /// Initializes a new instance of the <see cref="HospitalizationDataManagerStub"/> class.
        /// </summary>
        public HospitalizationDataManagerStub()
        {
            this.hospitalizationStubCollection = this.CreateHospitalizationStubCollection();
        }

        /// <summary>
        /// The get hospitalization collection.
        /// </summary>
        /// <param name="startDateTime">
        /// The start date time.
        /// </param>
        /// <param name="endDateTime">
        /// The end date time.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public IList<HospitalizationBase> GetHospitalizationCollection(DateTime startDateTime, DateTime endDateTime)
        {
            return

                // TODO временные интервалы
                // hospitalizationBaseCollection.Where(dt1 => dt1.EndDateTime >= startDateTime)
                // .Where(dt2 => dt2.EndDateTime <= endDateTime)
                // .ToList();

                // start<End<end || start<Enter<end
                this.hospitalizationStubCollection.Where(
                    dt1 =>
                    dt1.EndDateTime >= startDateTime && dt1.EndDateTime <= endDateTime
                    || (dt1.EnterDateTime >= startDateTime && dt1.EnterDateTime <= endDateTime)).ToList();
        }

        /// <summary>
        /// The get hospitalization collection.
        /// </summary>
        /// <param name="condition">
        /// The condition.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        public IList<HospitalizationBase> GetHospitalizationCollection(string condition)
        {
            return this.hospitalizationStubCollection;
        }

        /// <summary>
        /// The create hospitalization stub collection.
        /// </summary>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        private IList<HospitalizationBase> CreateHospitalizationStubCollection()
        {
            IList<HospitalizationBase> hospitalizationBaseCollection = new List<HospitalizationBase>();

            // 1
            var personIdentityInfo1 = new PersonIdentityInfoBase { DateOfBirth = new DateTime(1960, 5, 22) };
            var person1 = new PersonBase { PersonIdentityInfo = personIdentityInfo1 };
            var patient1 = new PatientBase { Person = person1 };
            var stay1ForPatient1 = new StayBase
            {
                DepartmentOutId = 3,
                DepartmentInId = 2,
                DepartmentFromId = 0,
                InDate = new DateTime(2007, 1, 1, 8, 50, 20), // 08:50:20 01.01.2007
                OutDate = new DateTime(2007, 1, 1, 17, 50, 20) // 17:50:20 01.01.2007
            };
            var stay2ForPatient1 = new StayBase
            {
                DepartmentOutId = 2,
                DepartmentInId = 3,
                DepartmentFromId = 2,
                InDate = new DateTime(2007, 1, 1, 17, 50, 15), // 17:50:15 01.01.2007
                OutDate = new DateTime(2007, 1, 1, 18, 15, 10) // 18:15:10 01.01.2007
            };

            var hosp1 = new HospitalizationBase
            {
                DischargeDepartmentId = 2,
                AdmissionDepartmentId = 2,
                EnterDateTime = new DateTime(2007, 1, 1, 7, 50, 20),

                // 07:50:20 01.01.2007
                EndDateTime = new DateTime(2007, 1, 1, 18, 50, 20),

                // 18:50:20 01.01.2007
                Patient = patient1,
                MedicalServiceResultId = 5,
                Villager = 1,
                StayList = new List<StayBase> { stay2ForPatient1, stay1ForPatient1 }
            };
            hospitalizationBaseCollection.Add(hosp1);

            // 2
            var personIdentityInfo2 = new PersonIdentityInfoBase { DateOfBirth = new DateTime(1994, 1, 2) };
            var person2 = new PersonBase { PersonIdentityInfo = personIdentityInfo2 };
            var patient2 = new PatientBase { Person = person2 };
            var hosp2 = new HospitalizationBase
            {
                DischargeDepartmentId = 3,
                AdmissionDepartmentId = 3,
                EnterDateTime = new DateTime(2007, 1, 1, 6, 50, 20),

                // 6:50:20 01.01.2007
                EndDateTime = new DateTime(2007, 1, 10, 12, 10, 20),

                // 12:10:20 10.01.2007
                Patient = patient2,
                MedicalServiceResultId = 5,
                Villager = 1,
                StayList = new List<StayBase>()
            };
            hospitalizationBaseCollection.Add(hosp2);

            // 3
            var personIdentityInfo3 = new PersonIdentityInfoBase { DateOfBirth = new DateTime(1990, 11, 12) };
            var person3 = new PersonBase { PersonIdentityInfo = personIdentityInfo3 };
            var patient3 = new PatientBase { Person = person3 };
            var hosp3 = new HospitalizationBase
            {
                DischargeDepartmentId = 2,
                AdmissionDepartmentId = 3,
                EnterDateTime = new DateTime(2007, 2, 9, 10, 50, 20),

                // 10:50:20 09.02.2007
                EndDateTime = new DateTime(2007, 2, 10, 11, 50, 20),

                // 11:50:20 10.02.2007
                Patient = patient3,
                MedicalServiceResultId = 0,
                Villager = 0,
                StayList = new List<StayBase>()
            };
            hospitalizationBaseCollection.Add(hosp3);

            // 4
            var personIdentityInfo4 = new PersonIdentityInfoBase { DateOfBirth = new DateTime(2000, 3, 30) };
            var person4 = new PersonBase { PersonIdentityInfo = personIdentityInfo4 };
            var patient4 = new PatientBase { Person = person4 };
            var hosp4 = new HospitalizationBase
            {
                DischargeDepartmentId = 2,
                AdmissionDepartmentId = 3,
                EnterDateTime = new DateTime(2007, 2, 7, 20, 15, 30),

                // 20:15:30 07.02.2007
                EndDateTime = new DateTime(2007, 2, 13, 8, 15, 20),

                // 08:15:20 13.02.2007
                Patient = patient4,
                MedicalServiceResultId = 0,
                Villager = 0,
                StayList = new List<StayBase>()
            };
            hospitalizationBaseCollection.Add(hosp4);

            // 5
            var personIdentityInfo5 = new PersonIdentityInfoBase { DateOfBirth = new DateTime(1970, 9, 7) };
            var person5 = new PersonBase { PersonIdentityInfo = personIdentityInfo5 };
            var patient5 = new PatientBase { Person = person5 };
            var stay1ForPatient5 = new StayBase
            {
                DepartmentOutId = 3,
                DepartmentInId = 2,
                DepartmentFromId = 4,
                InDate = new DateTime(2007, 2, 3, 18, 15, 20), // 18:15:20 03.02.2007
                OutDate = new DateTime(2007, 2, 5, 8, 30, 0) // 8:30:00 05.02.2007
            };

            var hosp5 = new HospitalizationBase
            {
                DischargeDepartmentId = 2,
                AdmissionDepartmentId = 3,
                EnterDateTime = new DateTime(2007, 2, 3, 17, 50, 20),

                // 17:50:20 03.02.2007
                EndDateTime = new DateTime(2007, 2, 5, 9, 0, 0), // 9:00:00 05.02.2007
                Patient = patient5,
                MedicalServiceResultId = 0,
                Villager = 1,
                StayList = new List<StayBase> { stay1ForPatient5 }
            };
            hospitalizationBaseCollection.Add(hosp5);

            // 6
            var personIdentityInfo6 = new PersonIdentityInfoBase { DateOfBirth = new DateTime(1970, 9, 7) };
            var person6 = new PersonBase { PersonIdentityInfo = personIdentityInfo6 };
            var patient6 = new PatientBase { Person = person6 };
            var hosp6 = new HospitalizationBase
            {
                DischargeDepartmentId = 2,
                AdmissionDepartmentId = 3,
                EnterDateTime = new DateTime(2007, 2, 5, 19, 50, 20),

                // 19:50:20 05.02.2007
                EndDateTime = new DateTime(2007, 2, 15, 8, 0, 0),

                // 8:00:00 15.02.2007
                Patient = patient6,
                MedicalServiceResultId = 0,
                Villager = 0,
                StayList = new List<StayBase>()
            };
            hospitalizationBaseCollection.Add(hosp6);
            return hospitalizationBaseCollection;
        }
    }
}