// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportService.cs" company="">
//   
// </copyright>
// <summary>
//   The report service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Windows
{
    using System;
    using System.Diagnostics;
    using System.ServiceProcess;

    using Microsoft.Owin.Hosting;

    using XMIS.Report.Service.Front.Common;

    /// <summary>
    ///     The report service.
    /// </summary>
    /// <remarks>
    ///     Common error is:
    ///     System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation. --->
    ///     System.Net.HttpListenerException: Access is denied
    ///     To resolve it:
    ///     Start the service with administrator rights.
    ///     More information on
    ///     http://stackoverflow.com/questions/25383104/signalr-cannot-connect-to-http-localhost8080-self-hosted-server-using-the-fu
    /// </remarks>
    public partial class ReportService : ServiceBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ReportService" /> class.
        /// </summary>
        public ReportService()
        {
            this.InitializeComponent();
        }

        // More information on http://weblog.west-wind.com/posts/2013/Sep/04/SelfHosting-SignalR-in-a-Windows-Service
        /// <summary>
        ///     Gets or sets the signal r.
        /// </summary>
        private IDisposable SignalR { get; set; }

        /// <summary>
        /// The on start.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        protected override void OnStart(string[] args)
        {
            try
            {
                // TODO Logger
                var serviceUrl = "http://localhost:8080/";

                // serviceUrl = ConfigurationManager.AppSettings["SvcUrl"];
                this.SignalR = WebApp.Start<ServiceStartup>(serviceUrl);
                this.AddLog("XMIS.Report client front service has started");
            }
            catch (Exception ex)
            {
                this.AddLog(ex.Message + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        ///     The on stop.
        /// </summary>
        protected override void OnStop()
        {
            this.SignalR.Dispose();
            this.AddLog("XMIS.Report client front service has stopped");
        }

        /// <summary>
        /// The add log.
        /// </summary>
        /// <param name="log">
        /// The log.
        /// </param>
        private void AddLog(string log)
        {
            if (!EventLog.SourceExists("XMIS.Report.ReportService"))
            {
                EventLog.CreateEventSource("XMIS.Report.ReportService", "XMIS.Report.ReportService");
            }

            this.EventLog.Source = "XMIS.Report.ReportService";
            this.EventLog.WriteEntry(log);
        }
    }
}