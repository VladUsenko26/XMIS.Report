// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StayDataManagerTester.cs" company="">
//   
// </copyright>
// <summary>
//   The stay data manager tester.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Core.DAL.Test
{
    using System;

    using NUnit.Framework;

    using XMIS.Report.Service.Contract;

    /// <summary>
    /// The stay data manager tester.
    /// </summary>
    [TestFixture]
    public class StayDataManagerTester
    {
        /// <summary>
        /// The stay data manager.
        /// </summary>
        private readonly IStayDataManager stayDataManager = new StayDataManager();

        /// <summary>
        /// The get stay collection test.
        /// </summary>
        [Test]
        public void GetStayCollectionTest()
        {
            var stayCollection = this.stayDataManager.GetStayCollection(string.Empty);
            Console.WriteLine(stayCollection.Count);
            Assert.IsTrue(stayCollection.Count > 0);
        }
    }
}