// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Windows
{
    using System.ServiceProcess;

    /// <summary>
    ///     The program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            ServiceBase[] ServiceToRun;
            ServiceToRun = new ServiceBase[] { new ReportService() };
            ServiceBase.Run(ServiceToRun);
        }
    }
}