// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SqlDataHelper.cs" company="">
//   
// </copyright>
// <summary>
//   The sql data helper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.DAL
{
    using System;
    using System.Data;
    using System.Data.OleDb;

    using Common.DAL.Exception;

    /// <summary>
    /// The sql data helper.
    /// </summary>
    public class SqlDataHelper
    {
        /// <summary>
        /// The connection string pattern.
        /// </summary>
        private string connectionStringPattern = @"provider=VFPOLEDB.1; data source= '{0}';password='';user id=''";

        /// <summary>
        /// The ole db connection.
        /// </summary>
        private OleDbConnection oleDbConnection;

        /// <summary>
        /// The do query.
        /// </summary>
        /// <param name="directoryName">
        /// The directory name.
        /// </param>
        /// <param name="query">
        /// The query.
        /// </param>
        /// <returns>
        /// The <see cref="DataTable"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        public DataTable DoQuery(string directoryName, string query)
        {
            try
            {
                string connectionString = string.Format(this.connectionStringPattern, directoryName);
                DataTable dataTable = new DataTable();
                this.oleDbConnection = new OleDbConnection(connectionString);
                this.oleDbConnection.Open();
                if (this.oleDbConnection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(query, this.oleDbConnection);
                    oleDbDataAdapter.Fill(dataTable);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                // System.InvalidOperationException : The 'VFPOLEDB.1' provider is not registered on the local machine.
                if (ex is InvalidOperationException
                    && ex.Message == "The 'VFPOLEDB.1' provider is not registered on the local machine.")
                {
                    throw new Exception("Check your program is configured to run on 0x86 CPU.", ex);
                }
                else
                {
                    throw ex;
                }
            }
            finally
            {
                this.oleDbConnection.Close();
            }
        }

        /// <summary>
        /// The get data table.
        /// </summary>
        /// <param name="directoryName">
        /// The directory name.
        /// </param>
        /// <param name="tableName">
        /// The table name.
        /// </param>
        /// <returns>
        /// The <see cref="DataTable"/>.
        /// </returns>
        /// <exception cref="InvalidDataSourceException">
        /// </exception>
        /// <exception cref="GetDataTableException">
        /// </exception>
        /// <exception cref="Exception">
        /// </exception>
        public DataTable GetDataTable(string directoryName, string tableName)
        {
            string connectionString = string.Format(this.connectionStringPattern, directoryName);
            try
            {
                DataTable dataTable = new DataTable();
                this.oleDbConnection = new OleDbConnection(connectionString);
                this.oleDbConnection.Open();
                if (this.oleDbConnection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(
                        "select * from " + tableName,
                        this.oleDbConnection);
                    oleDbDataAdapter.Fill(dataTable);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                if (ex is OleDbException)
                {
                    if (ex.Message == "Invalid path or file name.")
                    {
                        InvalidDataSourceException invalidDataSourceException =
                            new InvalidDataSourceException("Invalid data source exception", ex);
                        invalidDataSourceException.Data.Add("dataSource", directoryName);
                        invalidDataSourceException.Data.Add("connection", connectionString);
                        throw invalidDataSourceException;
                    }
                    else
                    {
                        // File 'pp_cntry.dbf' does not exist.
                        GetDataTableException getDataTableException = new GetDataTableException(
                            "Get data table failed",
                            ex);
                        getDataTableException.Data.Add("table", tableName);
                        getDataTableException.Data.Add("connection", connectionString);
                        throw getDataTableException;
                    }
                }
                else
                {
                    throw ex;
                }

                throw;
            }
            finally
            {
                this.oleDbConnection.Close();
            }
        }
    }
}