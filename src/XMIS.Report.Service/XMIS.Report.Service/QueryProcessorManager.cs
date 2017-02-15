// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryProcessorManager.cs" company="">
//   
// </copyright>
// <summary>
//   The query processor manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using XMIS.Report.Core.Processor;
using XMIS.Report.Core.Processor.FormQueryProcessor;
using XMIS.Report.Domain.Hospitalization;
using XMIS.Report.Service.Contract;
using XMIS.Report.Service.Converters;

#endregion

namespace XMIS.Report.Service
{
    /// <summary>
    ///     The query processor manager.
    /// </summary>
    public class QueryProcessorManager
    {
        /// <summary>
        ///     The accordance processor dictionary.
        /// </summary>
        private readonly IDictionary<string, IQueryProcessor> accordanceProcessorDictionary;

        /// <summary>
        ///     The hospitalization data manager.
        /// </summary>
        private readonly IHospitalizationDataManager hospitalizationDataManager;

        /// <summary>
        ///     The hospitalization base collection.
        /// </summary>
        private IList<HospitalizationBase> hospitalizationBaseCollection;

        /// <summary>
        /// The hospitalization query processor.
        /// </summary>
        private HospitalizationQueryProcessor hospitalizationQueryProcessor;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryProcessorManager"/> class.
        /// </summary>
        /// <param name="hospitalizationDataManager">
        /// The hospitalization Data Manager.
        /// </param>
        public QueryProcessorManager(IHospitalizationDataManager hospitalizationDataManager)
        {
            accordanceProcessorDictionary = new Dictionary<string, IQueryProcessor>();

            this.hospitalizationDataManager = hospitalizationDataManager;

            // DalManagerFactory.Initialize();
            // this.hospitalizationDataManager = DalManagerFactory.Config.HospitalizationDataManagerStub;
            // this.hospitalizationBaseCollection = new List<HospitalizationBase>();
        }

        /// <summary>
        /// The do query.
        /// </summary>
        /// <param name="reportName">
        /// The report name.
        /// </param>
        /// <param name="startDateTime">
        /// The start date time.
        /// </param>
        /// <param name="endDateTime">
        /// The end date time.
        /// </param>
        /// <param name="departmentIdCollection">
        /// The department id collection.
        /// </param>
        /// <returns>
        /// The <see cref="DataTable"/>.
        /// </returns>
        public DataTable DoQuery(
            string reportName, 
            DateTime startDateTime, 
            DateTime endDateTime, 
            List<int> departmentIdCollection)
        {
            // this.hospitalizationBaseCollection = this.hospitalizationDataManager.GetHospitalizationCollection(startDateTime, endDateTime);
            var start = startDateTime.AddMonths(-3);
            var end = endDateTime.AddMonths(3);

            string condition = @" AND a.pos_d >= TTOD({" + start + "}) AND a.out_d <= TTOD({" + end + "})";
            var hospitalizationCollection = hospitalizationDataManager.GetHospitalizationCollection(condition);


            this.hospitalizationQueryProcessor = new HospitalizationQueryProcessor(hospitalizationCollection);
            this.hospitalizationBaseCollection = hospitalizationQueryProcessor.DoHospitalizationQuery(
                startDateTime, 
                endDateTime);


            this.InitializeProcessorDictionary();

            // IEnumerable<DataTable> dataTable = null;
            var dataTable = new DataTable();
            IQueryProcessor queryProcessor;

            if (this.accordanceProcessorDictionary.ContainsKey(reportName))
            {
                queryProcessor = this.accordanceProcessorDictionary[reportName];
                dataTable = queryProcessor.GetDataForForm(startDateTime, endDateTime, departmentIdCollection);

                // dataTable = accordanceProcessorDictionary.Values.Select(v => v.GetDataForForm(startDateTime, endDateTime, departmentIdCollection));
            }

            this.DoTotalSumByDepartment(dataTable);
            return dataTable;
        }

        /// <summary>
        /// The do total sum by department.
        /// </summary>
        /// <param name="dataTable">
        /// The data table.
        /// </param>
        private void DoTotalSumByDepartment(DataTable dataTable)
        {
            DepartmentManager departmentManager = new DepartmentManager();
            var departmentWithChildrenDictionary = departmentManager.GetDepartmentWithChildrenCollectionId();

            foreach (KeyValuePair<int, List<int>> keyValuePair in departmentWithChildrenDictionary)
            {
                Dictionary<string, int> totalByDepartment = new Dictionary<string, int>();
                foreach (DataColumn dataColumn in dataTable.Columns)
                {
                    if (dataColumn.DataType == typeof (int))
                    {
                        var total = dataTable.AsEnumerable().
                            Where(y => keyValuePair.Value.Contains(y.Field<int>("DepartmentId"))).
                            Sum(x => x.Field<int>(dataColumn.ColumnName));

                        totalByDepartment.Add(dataColumn.ColumnName, total);
                    }
                }

                DataRow resultRow = dataTable.Select("DepartmentId=" + keyValuePair.Key).FirstOrDefault();

                if (resultRow != null)
                {
                    foreach (KeyValuePair<string, int> pair in totalByDepartment)
                    {
                        resultRow[pair.Key] = pair.Value;
                    }
                }
            }
        }

        /// <summary>
        ///     The initialize.
        /// </summary>
        private void InitializeProcessorDictionary()
        {
            this.accordanceProcessorDictionary.Add("form7", new Form7QueryProcessor(hospitalizationBaseCollection));
            this.accordanceProcessorDictionary.Add(
                "form16", 
                new Form16QueryProcessor(hospitalizationBaseCollection));
        }

        /// <summary>
        /// The do query xml.
        /// </summary>
        /// <param name="reportName">
        /// The report name.
        /// </param>
        /// <param name="startDateTime">
        /// The start date time.
        /// </param>
        /// <param name="endDateTime">
        /// The end date time.
        /// </param>
        /// <param name="departmentIdCollection">
        /// The department id collection.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string DoQueryXML(
            string reportName, 
            DateTime startDateTime, 
            DateTime endDateTime, 
            List<int> departmentIdCollection)
        {
            var dataTable = this.DoQuery(reportName, startDateTime, endDateTime, departmentIdCollection);
            var xml = DataTableToXMLConverter.ConvertDataTableToXML(dataTable);
            return xml;
        }
    }
}