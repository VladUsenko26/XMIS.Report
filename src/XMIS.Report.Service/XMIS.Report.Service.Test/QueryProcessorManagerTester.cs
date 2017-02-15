// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryProcessorManagerTester.cs" company="">
//   
// </copyright>
// <summary>
//   The query processor manager tester.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Test
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    using NUnit.Framework;

    using XMIS.Report.Service.ConfigDataManager;

    /// <summary>
    ///     The query processor manager tester.
    /// </summary>
    [TestFixture]
    public class QueryProcessorManagerTester
    {
        /// <summary>
        ///     The do querytest.
        /// </summary>
        [Test]
        public void DoQueryTest()
        {
            var hospitalizationDataManager = DalManagerFactory.CreateHospitalizationDataManager("stub");
            var queryProcessorManager = new QueryProcessorManager(hospitalizationDataManager);
            var reportName = "form16";

            var startDate = new DateTime(2007, 1, 1, 7, 59, 0); // 7:59:00 01.01.2007
            var endDate = new DateTime(2007, 1, 11, 8, 0, 0); // 8:00:00 11.01.2007

            // DateTime startDate = new DateTime(2007, 2, 4, 7, 59, 0); // 7:59:00 04.02.2007
            // DateTime endDate = new DateTime(2007, 2, 13, 8, 0, 0); // 8:00:00 13.02.2007

            /*
                        1 - хирургия1;
                        2 - хирургия2;
                        3 - хирургия3;
            */
            var departmentIdCollection = new List<int> { 1, 2, 3 };
            var data = queryProcessorManager.DoQuery(reportName, startDate, endDate, departmentIdCollection);

            /*  foreach (DataRow dataRow in data.Rows)
              {
                  foreach (var item in dataRow.ItemArray)
                  {
                      Console.WriteLine(item);
                  }
              }*/
            Console.WriteLine("Report :" + reportName);
            Console.WriteLine(startDate + " - " + endDate);
            foreach (DataRow row in data.Rows)
            {
                Console.WriteLine("--- Row ---");
                foreach (DataColumn column in data.Columns)
                {
                    Console.Write("Item: ");
                    Console.Write(column.ColumnName);
                    Console.Write(" -- \t");
                    Console.WriteLine(row[column]);
                }
            }
        }
    }
}