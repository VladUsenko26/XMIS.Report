// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PersonBase.cs" company="">
//   
// </copyright>
// <summary>
//   The  person base
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Domain.Person
{
    /// <summary>
    ///     The  person base
    /// </summary>
    public class PersonBase
    {
        #region Fields

        /// <summary>
        ///     The person identity info
        /// </summary>
        protected PersonIdentityInfoBase personIdentityInfo;

        #endregion

        #region Properties

        /// <summary>
        ///     The  person identity info
        /// </summary>
        public virtual PersonIdentityInfoBase PersonIdentityInfo
        {
            get
            {
                return this.personIdentityInfo;
            }

            set
            {
                this.personIdentityInfo = value;
            }
        }

        #endregion
    }
}