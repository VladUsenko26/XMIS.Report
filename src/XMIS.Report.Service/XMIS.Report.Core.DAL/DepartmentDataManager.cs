// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DepartmentDataManager.cs" company="">
//   
// </copyright>
// <summary>
//   The department data manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System.Collections.Generic;
using System.Data;
using XMIS.Report.Domain;
using XMIS.Report.Transform;

namespace XMIS.Report.Core.DAL
{
    /// <summary>
    /// The department data manager.
    /// </summary>
    public class DepartmentDataManager
    {
        /// <summary>
        ///     The data configuration.
        /// </summary>
        private readonly DataConfiguration dataConfiguration = new DataConfiguration();

        /// <summary>
        ///     The sql data helper.
        /// </summary>
        private readonly SqlDataHelper sqlDataHelper = new SqlDataHelper();

        /// <summary>
        /// The department transformer.
        /// </summary>
        private readonly DepartmentTransformer departmentTransformer;

        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentDataManager"/> class.
        /// </summary>
        public DepartmentDataManager()
        {
            this.dataConfiguration.ReadConfiguration();
            this.departmentTransformer = new DepartmentTransformer();
        }

        /// <summary>
        /// The get department collection.
        /// </summary>
        /// <param name="condition">
        /// The condition.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        public IList<DepartmentInfo> GetDepartmentCollection(string condition)
        {
            IList<DepartmentInfo> departmentCollection;

            var departmentDataTable = this.GetDataTable(this.dataConfiguration.Path, condition);
            departmentCollection = this.TransformToDepartmentCollection(departmentDataTable);
            return departmentCollection;
        }

        /// <summary>
        /// The transform to department collection.
        /// </summary>
        /// <param name="departmentDataTable">
        /// The department data table.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        private IList<DepartmentInfo> TransformToDepartmentCollection(DataTable departmentDataTable)
        {
            IList<DepartmentInfo> departmentCollection = new List<DepartmentInfo>();

            foreach (DataRow dataRow in departmentDataTable.Rows)
            {
                var department = this.departmentTransformer.Transform(dataRow);
                departmentCollection.Add(department);
            }

            return departmentCollection;
        }

        /// <summary>
        /// The get data table.
        /// </summary>
        /// <param name="directoryName">
        /// The directory name.
        /// </param>
        /// <param name="suffix">
        /// The suffix.
        /// </param>
        /// <returns>
        /// The <see cref="DataTable"/>.
        /// </returns>
        private DataTable GetDataTable(string directoryName, string suffix)
        {
            var command = @"SELECT o.kno, o.nameotdel, o.ownerid
                            FROM p_otdel o WHERE !EMPTY(o.nameotdel) {0}";
            var queryTable = this.sqlDataHelper.DoQuery(directoryName, string.Format(command, suffix));
            queryTable.TableName = "query";
            return queryTable;
        }
    }
}