// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PersonIdentityInfoBase.cs" company="">
//   
// </copyright>
// <summary>
//   The  person identity info base
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Domain.Person
{
    using System;

    /// <summary>
    ///     The  person identity info base
    /// </summary>
    public class PersonIdentityInfoBase
    {
        #region Fields

        /// <summary>
        ///     The date of birth
        /// </summary>
        protected DateTime dateOfBirth = DateTime.Now;

        /// <summary>
        ///     The first name
        /// </summary>
        protected string firstName;

        /// <summary>
        ///     The middle name
        /// </summary>
        protected string middleName;

        /// <summary>
        ///     The last name
        /// </summary>
        protected string lastName;

        /// <summary>
        ///     The person identity note
        /// </summary>
        protected string personIdentityNote;

        /// <summary>
        ///     The sex id
        /// </summary>
        protected int sexId = 1;

        #endregion

        #region Properties

        /// <summary>
        ///     The  date of birth
        /// </summary>
        public virtual DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            set
            {
                this.dateOfBirth = value;
            }
        }

        /// <summary>
        ///     The  first name
        /// </summary>
        public virtual string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        /// <summary>
        ///     The  middle name
        /// </summary>
        public virtual string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                this.middleName = value;
            }
        }

        /// <summary>
        ///     The  last name
        /// </summary>
        public virtual string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        /// <summary>
        ///     The  person identity note
        /// </summary>
        public virtual string PersonIdentityNote
        {
            get
            {
                return this.personIdentityNote;
            }

            set
            {
                this.personIdentityNote = value;
            }
        }

        /// <summary>
        ///     The  sex id
        /// </summary>
        public virtual int SexId
        {
            get
            {
                return this.sexId;
            }

            set
            {
                this.sexId = value;
            }
        }

        #endregion
    }
}