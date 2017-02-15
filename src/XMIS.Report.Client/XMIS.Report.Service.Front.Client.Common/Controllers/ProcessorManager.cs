// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProcessorManager.cs" company="">
//   
// </copyright>
// <summary>
//   The processor manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.Common.Controllers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The processor manager.
    /// </summary>
    public class ProcessorManager
    {
        /// <summary>
        ///     The processor collection.
        /// </summary>
        private readonly Dictionary<string, object> processorCollection = new Dictionary<string, object>();

        /// <summary>
        /// The add processor.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="processor">
        /// The processor.
        /// </param>
        public void AddProcessor(string name, object processor)
        {
            if (!this.processorCollection.ContainsKey(name))
            {
                this.processorCollection.Add(name, processor);
            }
        }

        /// <summary>
        /// The get processor.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        public object GetProcessor(string name)
        {
            try
            {
                return this.processorCollection[name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}