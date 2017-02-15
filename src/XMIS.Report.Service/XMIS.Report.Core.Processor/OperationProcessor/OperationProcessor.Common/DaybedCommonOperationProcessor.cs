// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DaybedCommonOperationProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The daybed common operation processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region

using System;
using System.Collections.Generic;
using System.Linq;
using XMIS.Report.Domain.Hospitalization;

#endregion

namespace XMIS.Report.Core.Processor.OperationProcessor.OperationProcessor.Common
{
    /// <summary>
    ///     The daybed common operation processor.
    /// </summary>
    public static class DaybedCommonOperationProcessor
    {
        /// <summary>
        /// The get daybed count.
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
        public static int GetDaybedCount(
            int departmentId, 
            DateTime fromDateTime, 
            DateTime toDateTime, 
            IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            int count = 0;
            var stayCollection = from h in hospitalizationBaseCollection
                from s in h.StayList
                where
                    s.DepartmentInId == departmentId && s.OutDate >= fromDateTime
                    && s.OutDate <= toDateTime
                select s;

            foreach (StayBase stayBase in stayCollection)
            {
                // TODO реанимация = 99
                if (stayBase.DepartmentOutId == 0)
                {
                    count += (int)(stayBase.OutDate - stayBase.InDate).TotalDays + 1;
                }
                else
                {
                    count += (int)(stayBase.OutDate - stayBase.InDate).TotalDays;
                }
            }

            return count;
        }
    }
}