// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TransferToOtherDepartmentOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The transfer to other department operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.Processor.OperationProcessor.OperationProcessor.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    ///     The transfer to other department common operation processor.
    /// </summary>
    public static class TransferToOtherDepartmentCommonOperationProcessor
    {
        /// <summary>
        /// The get transfer count.
        /// </summary>
        /// <param name="departmentId">
        /// The department id.
        /// </param>
        /// <param name="fromDateTime">
        /// The from date time.
        /// </param>
        /// <param name="toDateTime">
        /// The to date time.
        /// </param>
        /// <param name="hospitalizationBaseCollection">
        /// The hospitalization base collection.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GetTransferCount(
            int departmentId, 
            DateTime fromDateTime, 
            DateTime toDateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            return (from h in hospitalizationBaseCollection
                    from s in h.StayList
                    where
                        s.DepartmentInId == departmentId && s.DepartmentOutId != 0 && s.OutDate >= fromDateTime
                        && s.OutDate <= toDateTime
                    select s).Count();
        }
    }
}