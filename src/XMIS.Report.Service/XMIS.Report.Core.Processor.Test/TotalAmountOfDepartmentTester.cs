// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TotalAmountOfDepartmentTester.cs" company="">
//   
// </copyright>
// <summary>
//   The total amount of department tester.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Service.Test
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    using NUnit.Framework;

    using XMIS.Report.Core.Processor.FormQueryProcessor;
    using XMIS.Report.Domain.Hospitalization;
    using XMIS.Report.Service.ConfigDataManager;

    /// <summary>
    /// The total amount of department tester.
    /// </summary>
    [TestFixture]
    public class TotalAmountOfDepartmentTester
    {
        /// <summary>
        /// The total amount of department test.
        /// </summary>
        [Test]
        public void TotalAmountOfDepartmentTest()
        {
            var hospitalizationDataManager = DalManagerFactory.CreateHospitalizationDataManager("stub");
            var startDate = new DateTime(2006, 1, 1, 7, 59, 0); // 7:59:00 01.01.2007
            var endDate = new DateTime(2008, 1, 11, 8, 0, 0); // 8:00:00 11.01.2007
            IList<HospitalizationBase> hospitalizationCollection =
                hospitalizationDataManager.GetHospitalizationCollection(startDate, endDate);

            Form16QueryProcessor form16QueryProcessor = new Form16QueryProcessor(hospitalizationCollection);
            var departmentIdCollection = new List<int> { 1, 2, 3, 4 };

            var dataTable = form16QueryProcessor.GetDataForForm(startDate, endDate, departmentIdCollection);

            DepartmentManager departmentManager = new DepartmentManager();
            var globalDepartmentDictionary = departmentManager.GetDepartmentWithChildrenCollectionId();
            foreach (KeyValuePair<int, List<int>> keyValuePair in globalDepartmentDictionary)
            {
                Console.WriteLine("--Begin--");
                Console.WriteLine(keyValuePair.Key);
                foreach (int i in keyValuePair.Value)
                {
                    Console.Write(i + " , ");
                }

                Console.WriteLine("\n --End--");
            }

            foreach (KeyValuePair<int, List<int>> keyValuePair in globalDepartmentDictionary)
            {
                Dictionary<string, int> totalByDepartment = new Dictionary<string, int>();
                foreach (DataColumn dataColumn in dataTable.Columns)
                {
                    if (dataColumn.DataType == typeof(int))
                    {
                        var total = dataTable.AsEnumerable().
                            Where(y => keyValuePair.Value.Contains((y.Field<int>("DepartmentId")))).
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



            // Print result
            Console.WriteLine("Form 16 :");
            Console.WriteLine(startDate + " - " + endDate);
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("--- Row ---");
                foreach (DataColumn column in dataTable.Columns)
                {
                    Console.Write("Item: ");
                    Console.Write(column.ColumnName);
                    Console.Write("\t ");
                    Console.WriteLine(row[column]);
                }
            }
        }
    }
}