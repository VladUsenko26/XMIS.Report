// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Console
{
    using System;
    using System.Collections.Generic;

    using XMIS.Report.Service.ConfigDataManager;

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
          //  var hospitalizationDataManager = DalManagerFactory.CreateHospitalizationDataManager("stub");
            var hospitalizationDataManager = DalManagerFactory.CreateHospitalizationDataManager("default");
            var queryProcessorManager = new QueryProcessorManager(hospitalizationDataManager);

            var reportName = "form16";

            var startDate = new DateTime(2014, 1, 1, 7, 59, 0); // 7:59:00 01.01.2014
            var endDate = new DateTime(2014, 7, 11, 8, 0, 0); // 8:00:00 11.10.2014

            // DateTime startDate = new DateTime(2007, 2, 4, 7, 59, 0); // 7:59:00 04.02.2007
            // DateTime endDate = new DateTime(2007, 2, 13, 8, 0, 0); // 8:00:00 13.02.2007

            /*
                        1 - хирургия1;
                        2 - хирургия2;
                        3 - хирургия3;
            */
            var departmentIdCollection = new List<int> { 2, 3, 4, 5, 6 };

            // DataTable data = queryProcessorManager.DoQuery(reportName, startDate, endDate, departmentIdCollection);
            var xml = queryProcessorManager.DoQueryXML(reportName, startDate, endDate, departmentIdCollection);
            Console.WriteLine(xml);

            /*
                        Console.WriteLine("Form 7 :");
                        Console.WriteLine(startDate + " - " + endDate);
                        foreach (DataRow row in data.Rows)
                        {
                            Console.WriteLine("--- Row ---");
                            foreach (DataColumn column in data.Columns)
                            {
                                Console.Write("Item: ");
                                Console.Write(column.ColumnName);
                                Console.Write(" ");
                                Console.WriteLine(row[column]);
                            }
                        }


                        Console.WriteLine("Age check :");
                        DateTime birthDate = new DateTime(2000, 2, 29);
                        DateTime now = new DateTime(2009, 2, 28);
                        int age = now.Year - birthDate.Year;

                        if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                        {
                            age--;
                        }

                        Console.WriteLine("Age = " + age);
            */
         /*   Console.WriteLine("Span check :");
            var EnterDateTime = new DateTime(2007, 2, 5, 21, 50, 20); // 21:50:20 05.02.2007
            var EndDateTime = new DateTime(2007, 9, 6, 21, 50, 0); // 21:50:10 06.02.2007

            var span = EndDateTime.Subtract(EnterDateTime);
            Console.WriteLine("Span.Hours = " + span.Hours);
            Console.WriteLine("Span.Days = " + span.Days);

            if (span.Days == 0)
            {
                Console.WriteLine("Yes, prior to day...");
            }
            else
            {
                Console.WriteLine("No, prior to day...");
            }

            var dt = new DateTime(2007, 1, 1, 18, 15, 20); // 18:15:20 03.02.2007
            Console.WriteLine("dt = " + dt);
            var dt2 = dt.AddDays(-1);
            Console.WriteLine("dt2 = " + dt2);

            var reportProcessorManager = new ReportProcessorManager();
            var resultXml = reportProcessorManager.GetFillXmlReport(
                reportName, 
                startDate, 
                endDate, 
                departmentIdCollection);

      //      Console.WriteLine(resultXml);
      */
            Console.ReadLine();
        }
    }
}