// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubConfigurator.cs" company="">
//   
// </copyright>
// <summary>
//   The hub configurator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.Common.Controllers.Configuration
{
    /// <summary>
    ///     The hub configurator.
    /// </summary>
    public class HubConfigurator
    {
        /// <summary>
        ///     The processor manager.
        /// </summary>
        private readonly ProcessorManager processorManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="HubConfigurator"/> class.
        /// </summary>
        /// <param name="processorManager">
        /// The processor manager.
        /// </param>
        public HubConfigurator(ProcessorManager processorManager)
        {
            this.processorManager = processorManager;
        }
    }
}