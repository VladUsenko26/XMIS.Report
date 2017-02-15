// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceContext.cs" company="">
//   
// </copyright>
// <summary>
//   The service context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.Common.Context
{
    using Microsoft.AspNet.SignalR.Client;

    using XMIS.Report.Service.Front.Client.Common.Controllers.Configuration;

    /// <summary>
    ///     The service context.
    /// </summary>
    public static class ServiceContext
    {
        /// <summary>
        ///     Gets or sets the hub connection.
        /// </summary>
        public static HubConnection HubConnection { get; set; }

        /// <summary>
        ///     Gets or sets the report proxy.
        /// </summary>
        public static IHubProxy ReportProxy { get; set; }

        /// <summary>
        ///     Gets or sets the hub configurator.
        /// </summary>
        public static HubConfigurator HubConfigurator { get; set; }
    }
}