// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HospitalizationDataManager.cs" company="">
//   
// </copyright>
// <summary>
//   The hospitalization data manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using XMIS.Report.Domain.Hospitalization;
using XMIS.Report.Service.Contract;
using XMIS.Report.Transform;

namespace XMIS.Report.Core.DAL
{
    /// <summary>
    ///     The hospitalization data manager.
    /// </summary>
    public class HospitalizationDataManager : IHospitalizationDataManager
    {
        /// <summary>
        ///     The data configuration.
        /// </summary>
        private readonly DataConfiguration dataConfiguration = new DataConfiguration();

        /// <summary>
        ///     The hospitalization transformer.
        /// </summary>
        private readonly HospitalizationTransformer hospitalizationTransformer = new HospitalizationTransformer();

        /// <summary>
        ///     The sql data helper.
        /// </summary>
        private readonly SqlDataHelper sqlDataHelper = new SqlDataHelper();

        /// <summary>
        /// The stay data manager.
        /// </summary>
        private readonly StayDataManager stayDataManager = new StayDataManager();

        /// <summary>
        /// The stay collection.
        /// </summary>
        private IList<StayBase> stayCollection;

        /// <summary>
        ///     Initializes a new instance of the <see cref="HospitalizationDataManager" /> class.
        /// </summary>
        public HospitalizationDataManager()
        {
            dataConfiguration.ReadConfiguration();
        }

        /// <summary>
        /// The get hospitalization collection.
        /// </summary>
        /// <param name="condition">
        /// The condition.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        public IList<HospitalizationBase> GetHospitalizationCollection(string condition)
        {
            IList<HospitalizationBase> hospitalizationCollection;
            var hospitalizationDataTable = GetData(dataConfiguration.Path, condition);
            hospitalizationCollection = TransformToHospitalizationCollection(hospitalizationDataTable);

            return hospitalizationCollection;
        }

        /// <summary>
        /// The get hospitalization collection.
        /// </summary>
        /// <param name="startDateTime">
        /// The start date time.
        /// </param>
        /// <param name="endDateTime">
        /// The end date time.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public IList<HospitalizationBase> GetHospitalizationCollection(DateTime startDateTime, DateTime endDateTime)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The transform to hospitalization collection.
        /// </summary>
        /// <param name="hospitalizationDataTable">
        /// The hospitalization data table.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        private IList<HospitalizationBase> TransformToHospitalizationCollection(DataTable hospitalizationDataTable)
        {
            IList<HospitalizationBase> hospitalizationCollection = new List<HospitalizationBase>();
            try
            {
                foreach (DataRow dataRow in hospitalizationDataTable.Rows)
                {
                    var hospitalization = hospitalizationTransformer.Transform(dataRow);
                    hospitalizationCollection.Add(hospitalization);
                }

                stayCollection = stayDataManager.GetStayCollection(string.Empty);
                foreach (var hospitalizationBase in hospitalizationCollection)
                {
                    var stayList =
                        stayCollection.Where(s => s.HospitalizationId == hospitalizationBase.HospitalizationId).ToList();
                    hospitalizationBase.StayList = stayList;
                }

                return hospitalizationCollection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        /// <exception cref="NotImplementedException">
        /// </exception>
        private DataTable GetData(string directoryName, string suffix)
        {
            // TODO write command 20.05.16
            var command = @"SELECT a.nib, a.pac_born, a.pacfam, a.pacname, a.pacsurname, a.pac_sex,
                         a.pos_kno, a.out_kno, a.citycount, a.m_kres,
                         a.pos_t, a.pos_d, a.out_d, a.out_t, a.withmother
                         FROM so_otd b, so_pos a
                            WHERE a.nib = b.nib {0} ";

            var queryTable = sqlDataHelper.DoQuery(directoryName, string.Format(command, suffix));
            queryTable.TableName = "query";

            return queryTable;
        }
    }
}