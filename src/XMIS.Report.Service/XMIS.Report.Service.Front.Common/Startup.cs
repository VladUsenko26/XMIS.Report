// --------------------------------------------------------------------------------------------------------------------
// <copyright company="" file="Startup.cs">
//   
// </copyright>
// <summary>
//   The startup.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Common
{
    using System;

    using Microsoft.AspNet.SignalR;
    using Microsoft.Owin.Hosting;

    using Owin;

    /// <summary>
    ///     The startup.
    /// </summary>
    public class Startup
    {
        /// <summary>
        ///     The service url.
        /// </summary>
        private static string serviceUrl;

        /// <summary>
        ///     The start server.
        /// </summary>
        public static void StartServer()
        {
            serviceUrl = "http://localhost:8080/";

            // serviceUrl = ConfigurationManager.AppSettings["SvcUrl"];
            using (WebApp.Start<Startup>(serviceUrl))
            {
                Console.WriteLine("Server running at " + serviceUrl);
                Console.ReadLine();
            }
        }

        /// <summary>
        ///     The stop server.
        /// </summary>
        public static void StopServer()
        {
        }

        /// <summary>
        /// The configuration.
        /// </summary>
        /// <param name="app">
        /// The app.
        /// </param>
        public void Configuration(IAppBuilder app)
        {
            app.Map(
                "/signalr", 
                map =>
                    {
                        // Setup the cors middleware to run before SignalR.
                        // By default this will allow all origins. You can 
                        // configure the set of origins and/or http verbs by
                        // providing a cors options with a different policy.
                        // map.UseCors(CorsOptions.AllowAll);
                        var hubConfiguration = new HubConfiguration { EnableDetailedErrors = true };

                        // Run the SignalR pipeline. We're not using MapSignalR
                        // since this branch is already runs under the "/signalr"
                        // path.
                        map.RunSignalR(hubConfiguration);
                    });
        }
    }
}