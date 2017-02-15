// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StayBase.cs" company="">
//   
// </copyright>
// <summary>
//   The stay base.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Domain.Hospitalization
{
    using System;

    /// <summary>
    ///     The stay base.
    /// </summary>
    public class StayBase
    {
        /// <summary>
        /// The hospitalization id.
        /// </summary>
        protected int hospitalizationId;

        /// <summary>
        ///     The department from id.
        /// </summary>
        private int departmentFromId;

        /// <summary>
        ///     The department in id.
        /// </summary>
        private int departmentInId;

        /// <summary>
        ///     The department out id.
        /// </summary>
        private int departmentOutId;

        /// <summary>
        ///     The date of hospitalization.
        /// </summary>
        private DateTime inDate;

        /// <summary>
        ///     The date of discharge.
        /// </summary>
        private DateTime outDate;

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
        ///     Gets or sets the in date.
        /// </summary>
        public DateTime InDate
        {
            get
            {
                return this.inDate;
            }

            set
            {
                this.inDate = value;
            }
        }

        /// <summary>
        ///     Gets or sets the out date.
        /// </summary>
        public DateTime OutDate
        {
            get
            {
                return this.outDate;
            }

            set
            {
                this.outDate = value;
            }
        }

        /// <summary>
        ///     Gets or sets the department from id.
        /// </summary>
        public int DepartmentFromId
        {
            get
            {
                return this.departmentFromId;
            }

            set
            {
                this.departmentFromId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the department in id.
        /// </summary>
        public int DepartmentInId
        {
            get
            {
                return this.departmentInId;
            }

            set
            {
                this.departmentInId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the department out id.
        /// </summary>
        public int DepartmentOutId
        {
            get
            {
                return this.departmentOutId;
            }

            set
            {
                this.departmentOutId = value;
            }
        }
    }
}