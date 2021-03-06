﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="" file="UserCannotEnterTheSystem.feature.cs">
//   
// </copyright>
// <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// <summary>
//   The user cannot enter the system feature.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region Designer generated code


#pragma warning disable

namespace XMIS.Report.Service.Front.Client.UAT.Features._2_EnterTheSystem
{
    using TechTalk.SpecFlow;

    /// <summary>
    /// The user cannot enter the system feature.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UserCannotEnterTheSystem")]
    public partial class UserCannotEnterTheSystemFeature
    {
        /// <summary>
        /// The test runner.
        /// </summary>
        private ITestRunner testRunner;

#line 1 "UserCannotEnterTheSystem.feature"
#line hidden

        /// <summary>
        /// The feature setup.
        /// </summary>
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            FeatureInfo featureInfo =
                new TechTalk.SpecFlow.FeatureInfo(
                    new System.Globalization.CultureInfo("en-US"), 
                    "UserCannotEnterTheSystem", 
                    "\tIn order to enter the system\r\n\tAs a member off application\r\n\tI want to be able t"
                    + "o enter the system", 
                    ProgrammingLanguage.CSharp, 
                    (string[])(null));
            testRunner.OnFeatureStart(featureInfo);
        }

        /// <summary>
        /// The feature tear down.
        /// </summary>
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        /// <summary>
        /// The test initialize.
        /// </summary>
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }

        /// <summary>
        /// The scenario tear down.
        /// </summary>
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        /// <summary>
        /// The scenario setup.
        /// </summary>
        /// <param name="scenarioInfo">
        /// The scenario info.
        /// </param>
        public virtual void ScenarioSetup(ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }

        /// <summary>
        /// The scenario cleanup.
        /// </summary>
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }

        /// <summary>
        /// The user cannot enter the system.
        /// </summary>
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("user cannot enter the system")]
        [NUnit.Framework.CategoryAttribute("positive")]
        public virtual void UserCannotEnterTheSystem()
        {
            ScenarioInfo scenarioInfo =
                new TechTalk.SpecFlow.ScenarioInfo("user cannot enter the system", new[] { "positive" });
#line 7
            this.ScenarioSetup(scenarioInfo);
#line 8
            testRunner.Given(
                "I try to connect the service", 
                (string)(null), 
                (TechTalk.SpecFlow.Table)(null), 
                "Given ");
#line 9
            testRunner.When(
                "the result should be connected successfully", 
                (string)(null), 
                (TechTalk.SpecFlow.Table)(null), 
                "When ");
#line 10
            testRunner.When(
                "I enter the login: wrongUser and password: wrongPassword", 
                (string)(null), 
                (TechTalk.SpecFlow.Table)(null), 
                "When ");
#line 11
            testRunner.Then(
                "the result should be <user is not found>", 
                (string)(null), 
                (TechTalk.SpecFlow.Table)(null), 
                "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}

#pragma warning restore

#endregion