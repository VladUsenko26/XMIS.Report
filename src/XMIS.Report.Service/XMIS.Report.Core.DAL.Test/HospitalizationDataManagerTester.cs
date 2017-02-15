// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HospitalizationDataManagerTester.cs" company="">
//   
// </copyright>
// <summary>
//   The hospitalization data manager tester.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Data.OleDb;
using XMIS.Report.Domain.Hospitalization;

namespace XMIS.Report.Core.DAL.Test
{
    using System;

    using NUnit.Framework;

    using XMIS.Report.Service.Contract;

    /// <summary>
    /// The hospitalization data manager tester.
    /// </summary>
    [TestFixture]
    public class HospitalizationDataManagerTester
    {
        /// <summary>
        /// The hospitalization data manager.
        /// </summary>
        private readonly IHospitalizationDataManager hospitalizationDataManager = new HospitalizationDataManager();

        /// <summary>
        /// The get hospitalization test.
        /// </summary>
        [Test]
        public void GetHospitalizationTest()
        {
            var hospitalizationCollection = this.hospitalizationDataManager.GetHospitalizationCollection(string.Empty);

            Console.WriteLine(hospitalizationCollection.Count);

            Assert.IsTrue(hospitalizationCollection.Count > 0);
        }

        [Test]
        public void GetHospitalizationWithConditionTest()
        {
            /*
             *  1) Все события, которые начались в промежуток времени ( Точка принадлежит отрезку )
                            SELECT * FROM table WHERE In BETWEEN @start AND @end
                2) Все события, которые начались И закончились в промежутке времени ( Отрезок лежит в отрезке)
                            SELECT * FROM table WHERE In > @start AND Out < @end
                3) Все события, которые проходили в промежутке времени ( Отрезок пересекает отрезок )
                            SELECT * FROM table WHERE In < @end AND Out > @start
              
             * TTOD( ) Function - Returns a Date value from a DateTime expression.
             */

            string condition1 = @" AND (
                                      (a.pos_d BETWEEN CTOT('{0}') AND CTOT('{1}')) OR
                                      (a.pos_d >= CTOT('{0}') AND a.out_d <= CTOT('{1}')) OR
                                      (a.pos_d <= CTOT('{1}') AND a.out_d >= CTOT('{0}')) 
                                    )";

            string condition2 = @" AND ( a.pos_d > {5/11/14} )";

            //    DateTime startDate = new DateTime(2005, 2, 4, 7, 59, 0); // 7:59:00 04.02.2007
            //    DateTime endDate = new DateTime(2008, 2, 13, 8, 0, 0); // 8:00:00 13.02.2007

            var startDate = new DateTime(2014, 1, 1, 7, 59, 0); // 7:59:00 01.01.2014
            var endDate = new DateTime(2014, 7, 11, 8, 0, 0); // 8:00:00 11.10.2014

            var start = startDate.AddMonths(-3);
            var end = endDate.AddMonths(3);


            string condition3 = @" AND ( a.out_d  >= CTOT('{0}') AND a.out_d <= CTOT('{1}') )  
                                        OR  ( a.pos_d  >= CTOT('{0}') AND a.pos_d <= CTOT('{1}') )";

            string condition4 = @" AND a.pos_d >= TTOD({" + start + "}) AND a.out_d <= TTOD({" + end + "})";

            string condition5 = @" AND a.pos_d >= {4/1/14} AND a.out_d <= {1/11/15}";

     /*         IList<HospitalizationBase> hospitalizationCollection =
                  this.hospitalizationDataManager.GetHospitalizationCollection(string.Format(
                                             condition4,
                                             start.ToString("yyyyMMdd"),
                                             end.ToString("yyyyMMdd"))); */

            IList<HospitalizationBase> hospitalizationCollection =
                this.hospitalizationDataManager.GetHospitalizationCollection(condition4); 

            Console.WriteLine(hospitalizationCollection.Count);
            Assert.IsTrue(hospitalizationCollection.Count > 0);
        }
    }
}