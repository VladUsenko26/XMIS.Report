// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProcessorContext.cs" company="">
//   
// </copyright>
// <summary>
//   The processor context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.Common.Context
{
    using XMIS.Report.Service.Front.Client.Common.Controllers;

    /// <summary>
    ///     The processor context.
    /// </summary>
    public class ProcessorContext
    {
        /// <summary>
        ///     Gets or sets the processor manager.
        /// </summary>
        public static ProcessorManager ProcessorManager { get; set; }
    }
}