// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceStartup.cs" company="">
//   
// </copyright>
// <summary>
//   The service startup.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Common
{
    using System.Threading;

    using Microsoft.AspNet.SignalR;

    using Owin;

    using XMIS.Report.Service.Front.Common.Hubs;

    /// <summary>
    ///     The service startup.
    /// </summary>
    public class ServiceStartup
    {
        /// <summary>
        ///     The service url.
        /// </summary>
        private static string serviceUrl;

        /// <summary>
        ///     The service name.
        /// </summary>
        private static string serviceName;

        /// <summary>
        /// The configuration.
        /// </summary>
        /// <param name="app">
        /// The app.
        /// </param>
        public void Configuration(IAppBuilder app)
        {
            serviceUrl = "http://localhost:8080/";
            serviceName = "Service1";

            // serviceUrl = ConfigurationManager.AppSettings["SvcUrl"];
            GlobalHost.DependencyResolver.Register(typeof(ReportHub), () => new ReportHub());

            // Wait for everything has started
            Thread.Sleep(5000);

            var hubConfiguration = new HubConfiguration { EnableDetailedErrors = true, EnableJSONP = true };

            if (!string.IsNullOrEmpty(serviceName))
            {
                // http://www.asp.net/signalr/overview/performance/signalr-performance
                // DefaultMessageBufferSize: By default, SignalR retains 1000 messages in memory per hub per connection. 
                // If large messages are being used, this may create memory issues which can be alleviated by reducing this value. 
                // This setting can be set in the Application_Start event handler in an ASP.NET application, 
                // or in the Configuration method of an OWIN startup class in a self-hosted application. 
                // The following sample demonstrates how to reduce this value in order to reduce the memory footprint of your application
                // in order to reduce the amount of server memory used:
                GlobalHost.Configuration.DefaultMessageBufferSize = 500;
                app.MapSignalR("/" + serviceName, hubConfiguration);
            }
        }
    }
}