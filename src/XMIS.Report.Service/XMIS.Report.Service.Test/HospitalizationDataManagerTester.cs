// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HospitalizationDataManagerTester.cs" company="">
//   
// </copyright>
// <summary>
//   The hospitalization data manager tester.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Test
{
    using System;

    using NUnit.Framework;

    using XMIS.Report.Service.Contract;

    /// <summary>
    ///     The hospitalization data manager tester.
    /// </summary>
    [TestFixture]
    public class HospitalizationDataManagerTester
    {
        /// <summary>
        ///     The get hospitalization collection test.
        /// </summary>
        [Test]
        public void GetHospitalizationCollectionTest()
        {
            IHospitalizationDataManager hospitalizationDataManager = new HospitalizationDataManagerStub();
            var startDate = new DateTime(2007, 1, 1, 7, 59, 0); // 7:59:00 01.01.2007
            var endDate = new DateTime(2007, 1, 11, 8, 0, 0); // 8:00:00 11.01.2007
            var hospitalizationBaseCollection = hospitalizationDataManager.GetHospitalizationCollection(
                startDate, 
                endDate);
            Console.WriteLine("Count = " + hospitalizationBaseCollection.Count);
        }
    }
}