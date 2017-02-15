// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   The data configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.DAL
{
    using System;
    using System.Configuration;

    /// <summary>
    ///     The data configuration.
    /// </summary>
    public class DataConfiguration
    {
        /// <summary>
        ///     Gets or sets the path.
        /// </summary>
        public string Path { get; set; } = @"C:\ambcser";

        /// <summary>
        ///     The read configuration.
        /// </summary>
        /// <exception cref="Exception">
        /// </exception>
        public void ReadConfiguration()
        {
            try
            {
                this.Path = ConfigurationManager.AppSettings["dbpath"].Trim();
            }
            catch (Exception ex)
            {
                throw new Exception("Can't find configuration. Check your app.config file.", ex);
            }
        }
    }
}