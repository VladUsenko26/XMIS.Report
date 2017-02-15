// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProcessorManagerFactory.cs" company="">
//   
// </copyright>
// <summary>
//   The processor manager factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.Common.Controllers
{
    using XMIS.Report.Service.Front.Client.Common.Controllers.Configuration;

    /// <summary>
    ///     The processor manager factory.
    /// </summary>
    public static class ProcessorManagerFactory
    {
        /// <summary>
        ///     The create.
        /// </summary>
        /// <returns>
        ///     The <see cref="ProcessorManager" />.
        /// </returns>
        public static ProcessorManager Create()
        {
            var processorManager = new ProcessorManager();
            var processorConfigurator = new ProcessorConfigurator();
            processorConfigurator.Configure(processorManager);

            return processorManager;
        }
    }
}