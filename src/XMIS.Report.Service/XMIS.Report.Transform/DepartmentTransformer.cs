// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DepartmentTransformer.cs" company="">
//   
// </copyright>
// <summary>
//   The department transformer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Data;
using XMIS.Report.Domain;
using XMIS.Report.Transform.Extensions;

namespace XMIS.Report.Transform
{
    /// <summary>
    /// The department transformer.
    /// </summary>
    public class DepartmentTransformer
    {
        /// <summary>
        /// The transform.
        /// </summary>
        /// <param name="dataRow">
        /// The data row.
        /// </param>
        /// <returns>
        /// The <see cref="DepartmentInfo"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        public DepartmentInfo Transform(DataRow dataRow)
        {
            try
            {
                DepartmentInfo departmentInfo = new DepartmentInfo
                {
                    DepartmentId = dataRow["kno"].ToString().ToNumber(), 
                    DepartmentName = dataRow["nameotdel"].ToString(), 
                    OwnerId = dataRow["ownerid"].ToString().ToNumber()
                };


                return departmentInfo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}