// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StudentCanEnterTheSystemSteps.cs" company="">
//   
// </copyright>
// <summary>
//   The student can enter the system steps.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.UAT.Enter
{
    using System;
    using System.Threading;

    using NUnit.Framework;

    using TechTalk.SpecFlow;

    using XMIS.Report.Client.Domain;
    using XMIS.Report.Service.Front.Client.UAT.Context;

    /// <summary>
    ///     The student can enter the system steps.
    /// </summary>
    [Binding]
    public class EnterTester
    {
        /// <summary>
        /// The enter the system.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        [When(@"I enter the login:(.*) and password: (.*)")]
        public void EnterTheSystem(string login, string password)
        {
            TestingContext.FrontServiceClient.SystemEnter(login, password);
            Thread.Sleep(500);
        }

        /// <summary>
        ///     The then the result should be student entered successfully.
        /// </summary>
        [Then(@"the result should be student entered successfully")]
        public void ThenTheResultShouldBeStudentEnteredSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

        /// <summary>
        /// The enter successful.
        /// </summary>
        [Then("the result should be member entered successfully")]
        public void EnterSuccessful()
        {
            MemberInfo memberInfo = TestingContext.FrontServiceClient.MemberInfo;
            Assert.That(memberInfo.FaultInfoCollection.Count, Is.EqualTo(0));
        }

        /// <summary>
        /// The enter failed.
        /// </summary>
        [Then(@"the result should be <user is not found>")]
        public void EnterFailed()
        {
            MemberInfo memberInfo = TestingContext.FrontServiceClient.MemberInfo;
            Assert.That(memberInfo.FaultInfoCollection.Count, Is.Not.EqualTo(0));

            Console.WriteLine(memberInfo.FaultInfoCollection[0]);
        }
    }
}