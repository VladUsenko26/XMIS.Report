// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StayDescriptorTransformer.cs" company="">
//   
// </copyright>
// <summary>
//   The stay descriptor transformer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Transform
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    using XMIS.Report.Domain.Hospitalization;
    using XMIS.Report.Service.Contract;
    using XMIS.Report.Transform.Extensions;

    /// <summary>
    /// The stay descriptor transformer.
    /// </summary>
    public class StayDescriptorTransformer
    {
        /// <summary>
        /// The stay list.
        /// </summary>
        private List<StayBase> stayList;

        /// <summary>
        /// The transform.
        /// </summary>
        /// <param name="dataRow">
        /// The data row.
        /// </param>
        /// <returns>
        /// The <see cref="StayBase"/>.
        /// </returns>
        public StayBase Transform(DataRow dataRow)
        {
            return this.GetStay(dataRow);
        }

        /// <summary>
        /// The get stay.
        /// </summary>
        /// <param name="dataRow">
        /// The data row.
        /// </param>
        /// <returns>
        /// The <see cref="StayBase"/>.
        /// </returns>
        private StayBase GetStay(DataRow dataRow)
        {
            StayBase stay = new StayBase();
            stay.HospitalizationId = dataRow["nib"].ToString().ToNumber();
            stay.DepartmentFromId = dataRow["kno_in"].ToString().ToNumber();
            stay.DepartmentInId = dataRow["kno"].ToString().ToNumber();
            stay.DepartmentOutId = dataRow["kno_out"].ToString().ToNumber();

        //    int minutesIn = dataRow["t_in"].ToString().ToMinutes();
            stay.InDate = dataRow["d_in"].ToString().ToDateTime(0);

        //    int minutesOut = dataRow["t_out"].ToString().ToMinutes();
            stay.OutDate = dataRow["d_out"].ToString().ToDateTime(0);

            return stay;
        }
    }
}