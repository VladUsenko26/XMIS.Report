// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SystemConnectProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The system connect processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.Common.Controllers.Operation
{
    using System;

    using Microsoft.AspNet.SignalR.Client;

    using XMIS.Report.Service.Front.Client.Common.Context;

    /// <summary>
    ///     The system connect processor.
    /// </summary>
    public class SystemConnectProcessor
    {
        /// <summary>
        ///     Gets or sets the error.
        /// </summary>
        public string Error { get; set; } = string.Empty;

        /// <summary>
        /// The connect.
        /// </summary>
        /// <param name="serviceUrl">
        /// The service url.
        /// </param>
        public void Connect(string serviceUrl)
        {
            try
            {
                var hubConn = new HubConnection(serviceUrl);
                hubConn.Error += this.HubConnOnError;
                var reportHubProxy = hubConn.CreateHubProxy("reportHub");
                ServiceContext.HubConnection = hubConn;
                ServiceContext.ReportProxy = reportHubProxy;

                hubConn.Start().Wait();
            }
            catch (Exception ex)
            {
                this.Error = ex.Message;
                Console.WriteLine("Error: " + this.Error);
                throw;
            }
        }

        /// <summary>
        /// The hub conn on error.
        /// </summary>
        /// <param name="exception">
        /// The exception.
        /// </param>
        private void HubConnOnError(Exception exception)
        {
            this.Disconnect();
        }

        /// <summary>
        ///     The disconnect.
        /// </summary>
        public void Disconnect()
        {
            if (ServiceContext.HubConnection != null)
            {
                if (ServiceContext.HubConnection.State != ConnectionState.Disconnected)
                {
                    ServiceContext.HubConnection.Stop();
                }
            }
        }
    }
}