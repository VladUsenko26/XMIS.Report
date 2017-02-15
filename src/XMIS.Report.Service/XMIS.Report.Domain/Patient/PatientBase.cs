// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PatientBase.cs" company="">
//   
// </copyright>
// <summary>
//   The patient base.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Domain.Patient
{
    using XMIS.Report.Domain.Person;

    /// <summary>
    ///     The patient base.
    /// </summary>
    public class PatientBase
    {
        #region Fields

        /// <summary>
        ///     The person
        /// </summary>
        protected PersonBase person;

        #endregion

        #region Properties

        /// <summary>
        ///     The  person
        /// </summary>
        public virtual PersonBase Person
        {
            get
            {
                return this.person;
            }

            set
            {
                this.person = value;
            }
        }

        #endregion
    }
}