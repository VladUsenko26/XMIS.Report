// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SqlDataHelperTester.cs" company="">
//   
// </copyright>
// <summary>
//   The sql data helper tester.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Data;

namespace XMIS.Report.Core.DAL.Test
{
    using Common.DAL.Exception;

    using NUnit.Framework;

    /// <summary>
    ///     The sql data helper tester.
    /// </summary>
    [TestFixture]
    public class SqlDataHelperTester
    {
        /// <summary>
        ///     The sql data helper.
        /// </summary>
        private readonly SqlDataHelper sqlDataHelper = new SqlDataHelper();

        /// <summary>
        /// The get data table test.
        /// </summary>
        /// <param name="path">
        /// The path.
        /// </param>
        /// <param name="tableName">
        /// The table name.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        [TestCase(@"C:\ambcserr\baza.6", "p_cntry", ExpectedException = typeof(InvalidDataSourceException))]
        [TestCase(@"C:\ambcser\baza.6", "pp_cntry", ExpectedException = typeof(GetDataTableException))]
        [TestCase(@"C:\ambcser\baza.6", "p_cntry", Result = true)]
        public bool GetDataTableTest(string path, string tableName)
        {
            // string path = ConfigurationManager.AppSettings["dbpath"].Trim();
            // string tableName = "p_cntry"; 
            var dataTable = this.sqlDataHelper.GetDataTable(path, tableName);
            return dataTable.Rows.Count > 0;
        }

        [Test]
        public void GetDataTableTestWithCondition()
        {
            DataConfiguration dataConfiguration = new DataConfiguration();
            dataConfiguration.ReadConfiguration();

            string query = @"SELECT a.nib FROM so_pos a
                                WHERE a.pos_d > {5/11/14}";

            string query2 = @"SELECT a.nib, a.pac_born, a.pacfam, a.pacname, a.pacsurname, a.pac_sex,
                         a.pos_kno, a.out_kno, a.citycount, a.m_kres,
                         a.pos_t, a.pos_d, a.out_d, a.out_t, a.withmother
                         FROM so_otd b, so_pos a
                            WHERE a.nib = b.nib AND a.pos_d >= {4/1/14} AND a.out_d <= {1/11/15}";

            var queryTable = sqlDataHelper.DoQuery(dataConfiguration.Path, query2);

            Assert.IsTrue(queryTable.Rows.Count > 0);
            Console.WriteLine("Count = {0}", queryTable.Rows.Count);
        /*    foreach (DataRow dataRow in queryTable.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
            } */
        }
    }
}