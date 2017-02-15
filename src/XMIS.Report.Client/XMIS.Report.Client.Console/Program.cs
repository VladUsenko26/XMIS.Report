// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Client.Console
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    using XMIS.Report.Service.Front.Client.Common;

    /// <summary>
    ///     The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            /*   IHubProxy hub;
              string hubConnectionUrl = @"http://localhost:8080/";
              var connection = new HubConnection(hubConnectionUrl);
              hub = connection.CreateHubProxy("reportHub");
              connection.Start().Wait();


              //
              string reportName = "form7";
              DateTime startDate = new DateTime(2007, 1, 1, 7, 59, 0); // 7:59:00 01.01.2007
              DateTime endDate = new DateTime(2007, 1, 11, 8, 0, 0); // 8:00:00 11.01.2007
              List<int> departmentIdCollection = new List<int>() { 1, 2, 3 };
              //

              hub.Invoke("GetReport", reportName, startDate, endDate, departmentIdCollection); //param
              hub.On<DataTable>("ReceiveDataForReport", ReceiveDataForReport);
              */
            var reportName = "form7";
            var startDate = new DateTime(2007, 1, 1, 7, 59, 0); // 7:59:00 01.01.2007
            var endDate = new DateTime(2007, 1, 11, 8, 0, 0); // 8:00:00 11.01.2007
            var departmentIdCollection = new List<int> { 1, 2, 3 };

            var frontServiceClient = new FrontServiceClient();
            var hubConnectionUrl = @"http://localhost:8080/";
            frontServiceClient.Connect(hubConnectionUrl);
            var xml = frontServiceClient.GetReport(reportName, startDate, endDate, departmentIdCollection);

            Console.WriteLine(xml);
            Console.ReadKey();
        }

        /// <summary>
        /// The receive data for report.
        /// </summary>
        /// <param name="dataTable">
        /// The data table.
        /// </param>
        private static void ReceiveDataForReport(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("--- Row ---");
                foreach (DataColumn column in dataTable.Columns)
                {
                    Console.Write("Item: ");
                    Console.Write(column.ColumnName);
                    Console.Write(" ");
                    Console.WriteLine(row[column]);
                }
            }
        }
    }
}