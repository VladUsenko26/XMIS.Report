// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DischargeDateOperationProcessorTester.cs" company="">
//   
// </copyright>
// <summary>
//   The discharge date operation processor tester.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Test
{
    using System;
    using System.Collections.Generic;

    using NUnit.Framework;

    using XMIS.Report.Core.Processor.OperationProcessor.Form16OperationProcessor;
    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    ///     The discharge date operation processor tester.
    /// </summary>
    [TestFixture]
    public class DischargeDateOperationProcessorTester
    {
        /// <summary>
        ///     The get count test.
        /// </summary>
        [Test]
        public void GetCountTest()
        {
            IList<HospitalizationBase> hospitalizationBaseCollection = new List<HospitalizationBase>();

            var hosp1 = new HospitalizationBase
                            {
                                DischargeDepartmentId = 1, 
                                AdmissionDepartmentId = 1, 
                                EnterDateTime = new DateTime(2007, 1, 1), 
                                EndDateTime = new DateTime(2007, 1, 3)
                            };
            hospitalizationBaseCollection.Add(hosp1);

            var hosp2 = new HospitalizationBase
                            {
                                DischargeDepartmentId = 2, 
                                AdmissionDepartmentId = 2, 
                                EnterDateTime = new DateTime(2007, 1, 1), 
                                EndDateTime = new DateTime(2007, 1, 10)
                            };
            hospitalizationBaseCollection.Add(hosp2);

            var hosp3 = new HospitalizationBase
                            {
                                DischargeDepartmentId = 1, 
                                AdmissionDepartmentId = 2, 
                                EnterDateTime = new DateTime(2007, 2, 9), 
                                EndDateTime = new DateTime(2007, 2, 10)
                            };
            hospitalizationBaseCollection.Add(hosp3);
            var startDateTime = new DateTime(2006, 2, 9);
            var endDateTime = new DateTime(2008, 2, 9);

            var dischargeDateOperationProcessor = new DischargePatientOperationProcessor();
            var count = dischargeDateOperationProcessor.GetCount(
                1, 
                startDateTime, 
                endDateTime, 
                hospitalizationBaseCollection);
            Assert.AreEqual(2, count);
        }
    }
}