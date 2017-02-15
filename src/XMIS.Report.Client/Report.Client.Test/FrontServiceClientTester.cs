// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FrontServiceClientTester.cs" company="">
//   
// </copyright>
// <summary>
//   The front service client tester.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Client.Test
{
    using System.Collections.Generic;

    using NUnit.Framework;

    using Rhino.Mocks;

    using XMIS.Report.Client.Domain;
    using XMIS.Report.Service.Front.Client.Contract;

    /// <summary>
    ///     The front service client tester.
    /// </summary>
    [TestFixture]
    public class FrontServiceClientTester
    {
        /// <summary>
        ///     The test.
        /// </summary>
        [Test]
        public void Test()
        {
            // Arrange: create mocks,test data and expected methods calls
            var Reports = new List<ReportInfo>
                              {
                                  new ReportInfo { ReportId = 1, ReportName = "Форма №7/0" }, 
                                  new ReportInfo { ReportId = 2, ReportName = "Форма №16/0" }, 
                                  new ReportInfo { ReportId = 3, ReportName = "Форма №7/У" }
                              };

            var frontServiceClient = MockRepository.GenerateMock<IFrontServiceClient>();
            frontServiceClient.Expect(x => x.GetReportCollection()).Return(Reports);

            // Act: invoke testing method

            // Assert: verify expectations
            frontServiceClient.VerifyAllExpectations();
        }
    }
}