// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The query processor. It works under hospitalization collection which should be
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Core.Processor
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;

    /// <summary>
    /// The query processor.
    /// </summary>
    public class HospitalizationQueryProcessor
    {
        /// <summary>
        /// The hospitalization.
        /// </summary>
        private IList<HospitalizationBase> hospitalizationCollection;

        /// <summary>
        /// Initializes a new instance of the <see cref="HospitalizationQueryProcessor"/> class.
        /// </summary>
        /// <param name="hospitalizationBase">
        /// The hospitalization base.
        /// </param>
        public HospitalizationQueryProcessor(IList<HospitalizationBase> hospitalizationBase)
        {
            this.hospitalizationCollection = hospitalizationBase;
        }

        /// <summary>
        /// Gets or sets the hospitalization collection.
        /// </summary>
        public IList<HospitalizationBase> HospitalizationCollection
        {
            get
            {
                return this.hospitalizationCollection;
            }

            set
            {
                this.hospitalizationCollection = value;
            }
        }

        /// <summary>
        /// The do hospitalization query.
        /// </summary>
        /// <param name="startDateTime">
        /// The start date time.
        /// </param>
        /// <param name="endDateTime">
        /// The end date time.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        public IList<HospitalizationBase> DoHospitalizationQuery(DateTime startDateTime, DateTime endDateTime)
        {
            var start = startDateTime.AddMonths(-3);
            var end = endDateTime.AddMonths(3);
            //TODO выбор периода дат.
            return this.hospitalizationCollection;
           /*  this.hospitalization.Where(
                    dt1 =>
                    dt1.EndDateTime >= start && dt1.EndDateTime <= end
                    || (dt1.EnterDateTime >= start && dt1.EnterDateTime <= end)).ToList();*/
        }
    }
}