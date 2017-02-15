// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConnectTheServiceSteps.cs" company="">
//   
// </copyright>
// <summary>
//   The connect the service steps.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

using TechTalk.SpecFlow;

namespace XMIS.Report.Service.Front.Client.UAT
{
    using System.Configuration;

    using NUnit.Framework;

    using XMIS.Report.Service.Front.Client.UAT.Context;

    /// <summary>
    /// The connect the service steps.
    /// </summary>
    [Binding]
    public class HubTester
    {
        /// <summary>
        /// The connect the service.
        /// </summary>
        [Given("I try to connect the service")]
        public void ConnectTheService()
        {
            string serviceUrl = ConfigurationManager.AppSettings["ServiceUrl"];
            TestingContext.FrontServiceClient.Connect(serviceUrl);
        }

        /// <summary>
        /// The then the result should be connected succesfully.
        /// </summary>
        [Then(@"the result should be connected succesfully")]
        [When(@"the result should be connected succesfully")]
        public void ConnectResultSuccessful()
        {
            Assert.That(TestingContext.FrontServiceClient.ConnectionError, Is.EqualTo(string.Empty));
        }

        /// <summary>
        /// The disconnect from the server.
        /// </summary>
        [When(@"I try to disconnect from the server")]
        public void DisconnectFromTheServer()
        {
            TestingContext.FrontServiceClient.Disconnect();
        }

        /// <summary>
        /// The disconnect result succesful.
        /// </summary>
        [Then(@"the result should be disconnected succesfully")]
        public void DisconnectResultSuccesful()
        {
            Assert.IsTrue(TestingContext.FrontServiceClient.IsDisconnected);
        }

        /// <summary>
        /// The connect wrong service.
        /// </summary>
        [Given(@"I try to connect wrong service")]
        public void ConnectWrongService()
        {
            string serviceUrl = ConfigurationManager.AppSettings["ServiceUrl"] + "x";
            TestHelper.AssertRaises<AggregateException>(() => TestingContext.FrontServiceClient.Connect(serviceUrl));
        }

        /// <summary>
        /// The result failed.
        /// </summary>
        [Then(@"the result should be failed to connect")]
        public void ResultFailed()
        {
            Assert.That(TestingContext.FrontServiceClient.ConnectionError, Is.Not.EqualTo(string.Empty));
            Console.WriteLine(TestingContext.FrontServiceClient.ConnectionError);
        }
    }
}