// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form16QueryProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The form 16 query processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Core.Processor.FormQueryProcessor
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    using XMIS.Report.Core.Processor.OperationProcessor;
    using XMIS.Report.Core.Processor.OperationProcessor.Form16OperationProcessor;
    using XMIS.Report.Domain;
    using XMIS.Report.Domain.Hospitalization;
    using XMIS.Report.Service;
    using XMIS.Report.Service.Contract;

    /// <summary>
    ///     The form 16 query processor.
    /// </summary>
    public class Form16QueryProcessor : IQueryProcessor
    {
        /// <summary>
        ///     The column name collection.
        /// </summary>
        private readonly List<string> columnNameCollection = new List<string>
                                                                 {
                                                                     "Code_b",
                                                                     "ExpandedBeds_1",
                                                                     "MonthlyAverageBeds_2",
                                                                     "DischargeTransferredToOtherHospitals_10",
                                                                     "PerformedDaybedVillager_14",
                                                                     "DaybedRolledOnRepairCount_15",
                                                                     "DaybedMothersWithChildren_16"
                                                                 };

        /// <summary>
        ///     The hospitalization collection.
        /// </summary>
        private readonly IList<HospitalizationBase> hospitalizationCollection;

        /// <summary>
        ///     The operation processors collection.
        /// </summary>
        private readonly Dictionary<string, IOperationProcessor> operationProcessorCollection;

        /// <summary>
        ///     The department collection.
        /// </summary>
        private readonly IList<DepartmentInfo> departmentCollection;

        /// <summary>
        ///     The department manager.
        /// </summary>
        private readonly DepartmentManager departmentManager;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Form16QueryProcessor" /> class.
        /// </summary>
        /// <param name="hospitalizationBaseCollection">
        ///     The hospitalization base collection.
        /// </param>
        public Form16QueryProcessor(IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            this.hospitalizationCollection = hospitalizationBaseCollection;
            this.operationProcessorCollection = new Dictionary<string, IOperationProcessor>();
            this.Initialize();
            this.departmentManager = new DepartmentManager();
            this.departmentCollection = this.departmentManager.GetDepartmentCollection();
            this.CreateDataTableColunm();
        }

        /// <summary>
        ///     The get data for form.
        /// </summary>
        /// <param name="startDateTime">
        ///     The start date time.
        /// </param>
        /// <param name="endDateTime">
        ///     The end date time.
        /// </param>
        /// <param name="departmentIdCollection">
        ///     The department id collection.
        /// </param>
        /// <returns>
        ///     The <see cref="DataTable" />.
        /// </returns>
        public DataTable GetDataForForm(DateTime startDateTime, DateTime endDateTime, List<int> departmentIdCollection)
        {
            var dataTable = new DataTable();

            // Create column name for table, one time
            dataTable.Columns.Add("DepartmentName_a", typeof(string));
            dataTable.Columns.Add("DepartmentId", typeof(int));

            foreach (var keyValuePair in this.operationProcessorCollection)
            {
                dataTable.Columns.Add(keyValuePair.Key, typeof(int)); // "DischargeCount"
            }

            foreach (var departmentId in departmentIdCollection)
            {
                var dr = dataTable.NewRow();
                var departmentInfo = this.departmentCollection.FirstOrDefault(d => d.DepartmentId == departmentId);
                dr["DepartmentName_a"] = departmentInfo.DepartmentName;
                dr["DepartmentId"] = departmentInfo.DepartmentId;

                foreach (var keyValuePair in this.operationProcessorCollection)
                {
                    var operationProcessor = keyValuePair.Value;
                    var count = operationProcessor.GetCount(
                        departmentId,
                        startDateTime,
                        endDateTime,
                        this.hospitalizationCollection);

                    dr[keyValuePair.Key] = count;
                }

                dataTable.Rows.Add(dr);
            }

            return dataTable;
        }

        /// <summary>
        ///     The initialize.
        /// </summary>
        private void Initialize()
        {
            this.operationProcessorCollection.Add(
                "WereSickFromTheBeginOfPeriod_3",
                new SickPatientFromTheBeginOfPeriodOperationProcessor()); //
            this.operationProcessorCollection.Add("AdmissionCount_4", new AdmissionPatientOperationProcessor()); //
            this.operationProcessorCollection.Add("AdmissionVillagerCount_5", new VillagerAdmissionOperationProcessor());
            //
            this.operationProcessorCollection.Add(
                "AgeLessThan17Count_6",
                new AgeLessThan17AdmissionOperationProcessor()); //
            this.operationProcessorCollection.Add(
                "AgeLessThan14Count_6a",
                new AgeLessThan14AdmissionOperationProcessor());
            this.operationProcessorCollection.Add(
                "TransferredFromOtherDepartments_7",
                new TransferFromOtherDepartmentOperationProcessor()); //
            this.operationProcessorCollection.Add(
                "TransferredToOtherDepartments_8",
                new TransferToOtherDepartmentOperationProcessor()); //
            this.operationProcessorCollection.Add(
                "TransferredPriorToDay_8a",
                new TransferPriorToDayOperationProcessor()); //
            this.operationProcessorCollection.Add("DischargeCount_9", new DischargePatientOperationProcessor()); //
            this.operationProcessorCollection.Add(
                "DischargePriorToDayCount_10a",
                new DischargePatientPriorToDayOperationProcessor()); //
            this.operationProcessorCollection.Add("DeathCount_11", new DeathOperationProcessor()); //
            this.operationProcessorCollection.Add("DeathPriorToDayCount_11a", new DeathPriorToDayOperationProcessor());
            //
            this.operationProcessorCollection.Add("WereSickCount_12", new SickPatientOperationProcessor());//
            this.operationProcessorCollection.Add("WereSickVillagerCount_12a", new SickVillagerPatientOperationProcessor());//

            this.operationProcessorCollection.Add("PerformedDaybed_13", new DaybedOperationProcessor());//
            this.operationProcessorCollection.Add("PerformedDaybedVillager_14", new DaybedVillagerOperationProcessor());//
        }

        // <summary>
        /// <summary>
        ///     The create data table colunm.
        /// </summary>
        /// <returns>
        ///     The <see cref="DataTable" />.
        /// </returns>
        private DataTable CreateDataTableColunm()
        {
            var dataTable = new DataTable();
            foreach (var columnName in this.columnNameCollection)
            {
                dataTable.Columns.Add(columnName, typeof(int));
            }

            return dataTable;
        }

    }
}