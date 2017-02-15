#region

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using XMIS.Report.Core.Processor.OperationProcessor;
using XMIS.Report.Core.Processor.OperationProcessor.Form7OperationProcessor;
using XMIS.Report.Domain;
using XMIS.Report.Domain.Hospitalization;
using XMIS.Report.Service;
using XMIS.Report.Service.Contract;

#endregion

namespace XMIS.Report.Core.Processor.FormQueryProcessor
{
    /// <summary>
    ///     The form 7 query processor.
    /// </summary>
    public class Form7QueryProcessor : IQueryProcessor
    {
        /// <summary>
        ///     The column name collection.
        /// </summary>
        private readonly List<string> columnNameCollection = new List<string>
        {
            "Code_2",
            "ExpandedBeds_3",
            "RolledToRepairBeds_4",
            "DischargeTransferredToOtherHospitals_12"
        };

        /// <summary>
        ///     The department collection.
        /// </summary>
        private readonly IList<DepartmentInfo> departmentCollection;

        /// <summary>
        ///     The department manager.
        /// </summary>
        private readonly DepartmentManager departmentManager;

        /// <summary>
        ///     The hospitalization collection.
        /// </summary>
        private readonly IList<HospitalizationBase> hospitalizationCollection;

        /// <summary>
        ///     The operation processors collection.
        /// </summary>
        private readonly Dictionary<string, IOperationProcessor> operationProcessorCollection;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Form7QueryProcessor" /> class.
        /// </summary>
        /// <param name="hospitalizationBaseCollection">
        ///     The hospitalization base collection.
        /// </param>
        public Form7QueryProcessor(IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            hospitalizationCollection = hospitalizationBaseCollection;
            operationProcessorCollection = new Dictionary<string, IOperationProcessor>();
            Initialize();
            departmentManager = new DepartmentManager();
            departmentCollection = departmentManager.GetDepartmentCollection();
            CreateDataTableColunm();
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
        /// <exception cref="Exception">
        /// </exception>
        public DataTable GetDataForForm(DateTime startDateTime, DateTime endDateTime, List<int> departmentIdCollection)
        {
            var dataTable = new DataTable();

            // Create column name for table, one time
            dataTable.Columns.Add("DepartmentName_1", typeof (string));
            dataTable.Columns.Add("DepartmentId", typeof (int));

            foreach (var keyValuePair in operationProcessorCollection)
            {
                dataTable.Columns.Add(keyValuePair.Key, typeof (int));
            }

            foreach (var departmentId in departmentIdCollection)
            {
                var dr = dataTable.NewRow();
                var departmentInfo = departmentCollection.FirstOrDefault(d => d.DepartmentId == departmentId);
                dr["DepartmentName_1"] = departmentInfo.DepartmentName;
                dr["DepartmentId"] = departmentInfo.DepartmentId;

                foreach (var keyValuePair in operationProcessorCollection)
                {
                    var operationProcessor = keyValuePair.Value;
                    var count = operationProcessor.GetCount(
                        departmentId,
                        startDateTime,
                        endDateTime,
                        hospitalizationCollection);

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
            operationProcessorCollection.Add(
                "PatientsAtTheBeginningOfTheLastDay_5",
                new PatientAtTheBeginOfThePastDayOperationProcessor()); //
            operationProcessorCollection.Add(
                "AdmissionForThePastDayCount_6",
                new AdmissionPatientForThePastDayOperationProcessor()); //
            operationProcessorCollection.Add(
                "AdmissionVillagerForThePastDayCount_7",
                new VillagerAdmissionForThePastDayOperationProcessor()); //
            operationProcessorCollection.Add(
                "AgeLessThan17ForThePastDayCount_8",
                new AgeLessThan17AdmissionForThePastDayOperationProcessor()); //
            operationProcessorCollection.Add(
                "TransferredFromOtherDepartmentsForThePastDay_9",
                new TransferFromOtherDepartmentForThePastDayOperationProcessor()); //
            operationProcessorCollection.Add(
                "TransferredToOtherDepartmentsForThePastDay_10",
                new TransferToOtherDepartmentForThePastDayOperationProcessor()); //
            operationProcessorCollection.Add(
                "TransferredPriorToDayForThePastDay_10a",
                new TransferPriorToDayForThePastDayOperationProcessor()); //
            operationProcessorCollection.Add(
                "DischargeForThePastDayCount_11",
                new DischargePatientForThePastDayOperationProcessor()); //
            operationProcessorCollection.Add(
                "DischargePriorToDayForThePastDayCount_12a",
                new DischargePatientPriorToDayForThePastDayOperationProcessor()); //
            operationProcessorCollection.Add(
                "DeathForThePastDayCount_13",
                new DeathForThePastDayOperationProcessor()); //
            operationProcessorCollection.Add(
                "DeathPriorToDayCount_13a",
                new DeathPriorToDayForThePastDayOperationProcessor()); //
            operationProcessorCollection.Add("WereSickCount_14", new PatientAtTheBeginOfTheDayOperationProcessor());
            //
            operationProcessorCollection.Add(
                "WereSickVillagerCount_15",
                new VillagerPatientAtTheBeginOfTheDayOperationProcessor()); //
            operationProcessorCollection.Add(
                "AdmissionFromTheBeginOfTheMonthCount_16",
                new AdmissionPatientFromTheBeginOfTheMonthOperationProcessor()); //
            operationProcessorCollection.Add(
                "AdmissionVillagerFromTheBeginOfTheMonthCount_17",
                new VillagerAdmissionFromTheBeginOfTheMonthOperationProcessor()); //
            operationProcessorCollection.Add(
                "TransferredFromOtherDepartmentsFromTheBeginOfTheMonth_18",
                new TransferFromOtherDepartmentFromTheBeginOfTheMonthOperationProcessor()); //
            operationProcessorCollection.Add(
                "TransferredToOtherDepartmentsFromTheBeginOfTheMonth_19",
                new TransferToOtherDepartmentFromTheBeginOfTheMonthOperationProcessor()); //
            operationProcessorCollection.Add(
                "TransferredPriorToDayFromTheBeginOfTheMonth_20",
                new TransferPriorToDayFromTheBeginOfTheMonthOperationProcessor()); //
            operationProcessorCollection.Add(
                "DischargeFromTheBeginOfTheMonthCount_21",
                new DischargePatientFromTheBeginOfTheMonthOperationProcessor()); //
            operationProcessorCollection.Add(
                "DeathFromTheBeginOfTheMonthCount_22",
                new DeathFromTheBeginOfTheMonthOperationProcessor()); //
            operationProcessorCollection.Add("DaybedFromTheBeginOfTheMonth_24",
                new DaybedFromTheBeginOfTheMonthOperationProcessor()); //
            operationProcessorCollection.Add("DaybedVillagerFromTheBeginOfTheMonth_25",
                new DaybedVillagerFromTheBeginOfTheMonthOperationProcessor()); //
        }


        private DataTable CreateDataTableColunm()
        {
            var dataTable = new DataTable();
            foreach (var columnName in columnNameCollection)
            {
                dataTable.Columns.Add(columnName, typeof (int));
            }

            return dataTable;
        }
    }
}