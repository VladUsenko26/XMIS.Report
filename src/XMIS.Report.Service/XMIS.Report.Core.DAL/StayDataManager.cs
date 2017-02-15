// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StayDataManager.cs" company="">
//   
// </copyright>
// <summary>
//   The stay data manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    using XMIS.Report.Domain.Hospitalization;
    using XMIS.Report.Service.Contract;
    using XMIS.Report.Transform;

    /// <summary>
    /// The stay data manager.
    /// </summary>
    public class StayDataManager : IStayDataManager
    {
        /// <summary>
        ///     The data configuration.
        /// </summary>
        private readonly DataConfiguration dataConfiguration = new DataConfiguration();

        /// <summary>
        /// The stay descriptor transformer.
        /// </summary>
        private readonly StayDescriptorTransformer stayDescriptorTransformer = new StayDescriptorTransformer();

        /// <summary>
        /// The sql data helper.
        /// </summary>
        private readonly SqlDataHelper sqlDataHelper = new SqlDataHelper();

        /// <summary>
        /// Initializes a new instance of the <see cref="StayDataManager"/> class.
        /// </summary>
        public StayDataManager()
        {
            this.dataConfiguration.ReadConfiguration();
        }

        /// <summary>
        /// The get stay collection.
        /// </summary>
        /// <param name="condition">
        /// The condition.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        public IList<StayBase> GetStayCollection(string condition)
        {
            IList<StayBase> stayCollection;
            var stayDataTable = this.GetData(this.dataConfiguration.Path, condition);
            stayCollection = this.TransformToStayCollection(stayDataTable);
            return stayCollection;
        }

        /// <summary>
        /// The transform to stay collection.
        /// </summary>
        /// <param name="stayDataTable">
        /// The stay data table.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        private IList<StayBase> TransformToStayCollection(DataTable stayDataTable)
        {
            IList<StayBase> stayCollection = new List<StayBase>();

            try
            {
                foreach (DataRow dataRow in stayDataTable.Rows)
                {
                    var stay = this.stayDescriptorTransformer.Transform(dataRow);
                    stayCollection.Add(stay);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return stayCollection;
        }

        /// <summary>
        /// The get data.
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
        private DataTable GetData(string directoryName, string suffix)
        {
            var command = @"SELECT b.nib, b.kno_in, b.kno, b.kno_out, b.t_in, b.t_out, b.d_in, b.d_out
                             FROM so_otd b, so_pos a
                                WHERE a.nib = b.nib {0}";

            var queryTable = this.sqlDataHelper.DoQuery(directoryName, string.Format(command, suffix));
            queryTable.TableName = "query";

            return queryTable;
        }
    }
}