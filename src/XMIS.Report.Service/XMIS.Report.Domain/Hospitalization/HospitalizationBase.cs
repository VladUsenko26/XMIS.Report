// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HospitalizationBase.cs" company="">
//   
// </copyright>
// <summary>
//   The hospitalization base.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Domain.Hospitalization
{
    using System;
    using System.Collections.Generic;

    using XMIS.Report.Domain.Patient;

    /// <summary>
    ///     The hospitalization base.
    /// </summary>
    public class HospitalizationBase
    {
        #region Fields

        /// <summary>
        /// The hospitalization id.
        /// </summary>
        protected int hospitalizationId;

        /// <summary>
        ///     The enter date time
        /// </summary>
        protected DateTime enterDateTime;

        /// <summary>
        ///     The end date time
        /// </summary>
        protected DateTime endDateTime;

        /// <summary>
        ///     The admission department id
        /// </summary>
        protected int admissionDepartmentId;

        /// <summary>
        ///     The discharge department id
        /// </summary>
        protected int dischargeDepartmentId;

        /// <summary>
        /// The is with mother.
        /// </summary>
        protected bool isWithMother;

        /// <summary>
        ///     The patient
        /// </summary>
        protected PatientBase patient;

        /// <summary>
        ///     The medical service result id
        /// </summary>
        protected int medicalServiceResultId;

        /// <summary>
        ///     The villager.
        /// </summary>
        protected int villager;

        /// <summary>
        ///     The stay list.
        /// </summary>
        protected List<StayBase> stayList;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the hospitalization id.
        /// </summary>
        public virtual int HospitalizationId
        {
            get
            {
                return this.hospitalizationId;
            }

            set
            {
                this.hospitalizationId = value;
            }
        }

        /// <summary>
        ///     The  enter date time
        /// </summary>
        public virtual DateTime EnterDateTime
        {
            get
            {
                return this.enterDateTime;
            }

            set
            {
                this.enterDateTime = value;
            }
        }

        /// <summary>
        ///     The  end date time
        /// </summary>
        public virtual DateTime EndDateTime
        {
            get
            {
                return this.endDateTime;
            }

            set
            {
                this.endDateTime = value;
            }
        }

        /// <summary>
        ///     The  admission department id
        /// </summary>
        public virtual int AdmissionDepartmentId
        {
            get
            {
                return this.admissionDepartmentId;
            }

            set
            {
                this.admissionDepartmentId = value;
            }
        }

        /// <summary>
        ///     The  discharge department id
        /// </summary>
        public virtual int DischargeDepartmentId
        {
            get
            {
                return this.dischargeDepartmentId;
            }

            set
            {
                this.dischargeDepartmentId = value;
            }
        }

        /// <summary>
        ///     The  is with mother
        /// </summary>
        public virtual bool IsWithMother
        {
            get
            {
                return this.isWithMother;
            }

            set
            {
                this.isWithMother = value;
            }
        }

        /// <summary>
        ///     The  patient
        /// </summary>
        public virtual PatientBase Patient
        {
            get
            {
                return this.patient;
            }

            set
            {
                this.patient = value;
            }
        }

        /// <summary>
        ///     The  medical service result id
        /// </summary>
        public virtual int MedicalServiceResultId
        {
            get
            {
                return this.medicalServiceResultId;
            }

            set
            {
                this.medicalServiceResultId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the villager.
        /// </summary>
        public virtual int Villager
        {
            get
            {
                return this.villager;
            }

            set
            {
                this.villager = value;
            }
        }

        /// <summary>
        ///     Gets or sets the stay list.
        /// </summary>
        public List<StayBase> StayList
        {
            get
            {
                return this.stayList;
            }

            set
            {
                this.stayList = value;
            }
        }

        #endregion
    }
}