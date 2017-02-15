// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportManager.cs" company="">
//   
// </copyright>
// <summary>
//   The report manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service
{
    using System.Collections.Generic;

    using XMIS.Report.Domain;

    /// <summary>
    ///     The report manager.
    /// </summary>
    public class ReportListManager
    {
        /// <summary>
        ///     The report collection.
        /// </summary>
        private List<ReportInfo> reportCollection;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ReportListManager" /> class.
        /// </summary>
        public ReportListManager()
        {
            this.CreateReportCollection();
        }

        /// <summary>
        ///     The create report collection.
        /// </summary>
        private void CreateReportCollection()
        {
            this.reportCollection = new List<ReportInfo>
                                        {
                                            new ReportInfo
                                                {
                                                    ReportId = 1, 
                                                    ReportName = "form7", 
                                                    ReportDisplayName = "Форма №7/0"
                                                }, 
                                            new ReportInfo
                                                {
                                                    ReportId = 2, 
                                                    ReportName = "form16", 
                                                    ReportDisplayName = "Форма №16/0"
                                                }, 
                                            new ReportInfo
                                                {
                                                    ReportId = 3, 
                                                    ReportName = "form7y", 
                                                    ReportDisplayName = "Форма №7/У"
                                                }, 
                                            new ReportInfo
                                                {
                                                    ReportId = 4, 
                                                    ReportName = "form3500", 
                                                    ReportDisplayName =
                                                        "Форма 3500 (Хирургическая работа стационара)"
                                                }, 
                                            new ReportInfo
                                                {
                                                    ReportId = 4, 
                                                    ReportName = "form3220", 
                                                    ReportDisplayName =
                                                        "Форма 3220 (Состав больных в стационаре)"
                                                }
                                        };
        }

        /// <summary>
        ///     The get report collecrion.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<ReportInfo> GetReportCollection()
        {
            return this.reportCollection;
        }
    }
}