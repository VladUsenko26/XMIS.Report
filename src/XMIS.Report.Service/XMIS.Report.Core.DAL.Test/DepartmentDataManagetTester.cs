// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DepartmentDataManagetTester.cs" company="">
//   
// </copyright>
// <summary>
//   The department data managet tester.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region

using System;
using System.Collections.Generic;
using NUnit.Framework;
using XMIS.Report.Domain;

#endregion

namespace XMIS.Report.Core.DAL.Test
{
    /// <summary>
    /// The department data managet tester.
    /// </summary>
    [TestFixture]
    public class DepartmentDataManagetTester
    {
        /// <summary>
        /// The get department collection test.
        /// </summary>
        [Test]
        public void GetDepartmentCollectionTest()
        {
            DepartmentDataManager departmentDataManager = new DepartmentDataManager();

            IList<DepartmentInfo> departmentCollection = departmentDataManager.GetDepartmentCollection(string.Empty);

            Console.WriteLine("Department count = {0} ", departmentCollection.Count);

            foreach (DepartmentInfo departmentInfo in departmentCollection)
            {
                Console.WriteLine("Name = {0}; ID = {1}", departmentInfo.DepartmentName, departmentInfo.DepartmentId);
              
            }

            Assert.IsTrue(departmentCollection.Count > 0);
        }
    }
}