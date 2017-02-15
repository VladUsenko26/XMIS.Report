// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FrontServiceClient.cs" company="">
//   
// </copyright>
// <summary>
//   The front service client.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.Common
{
    using System;
    using System.Collections.Generic;

    using XMIS.Report.Client.Domain;
    using XMIS.Report.Service.Front.Client.Common.Controllers.Operation;
    using XMIS.Report.Service.Front.Client.Contract;

    /// <summary>
    ///     The front service client.
    /// </summary>
    public class FrontServiceClient : IFrontServiceClient
    {
        /// <summary>
        ///     The collection processor.
        /// </summary>
        private readonly CollectionProcessor collectionProcessor;

        /// <summary>
        ///     The report processor.
        /// </summary>
        private readonly ReportProcessor reportProcessor;

        /// <summary>
        ///     The system connection processor.
        /// </summary>
        private readonly SystemConnectProcessor systemConnectionProcessor;

        /// <summary>
        ///     The system enter processor.
        /// </summary>
        private readonly SystemEnterProcessor systemEnterProcessor;

        /// <summary>
        ///     Initializes a new instance of the <see cref="FrontServiceClient" /> class.
        /// </summary>
        public FrontServiceClient()
        {
            /* 
             *  For future extensibility
             *  ProcessorContext.ProcessorManager = ProcessorManagerFactory.Create();
             *  ServiceContext.HubConfigurator = new HubConfigurator(ProcessorContext.ProcessorManager);
            */
            this.collectionProcessor = new CollectionProcessor();
            this.reportProcessor = new ReportProcessor();
            this.systemEnterProcessor = new SystemEnterProcessor();
            this.systemConnectionProcessor = new SystemConnectProcessor();
        }

        /// <summary>
        ///     The get report collection.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<ReportInfo> GetReportCollection()
        {
            return this.collectionProcessor.GetReportCollection();
        }

        /// <summary>
        ///     The get department collection.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<DepartmentInfo> GetDepartmentCollection()
        {
            return this.collectionProcessor.GetDepartmentCollection();
        }

        /// <summary>
        /// The get report.
        /// </summary>
        /// <param name="reportName">
        /// The report name.
        /// </param>
        /// <param name="dateStart">
        /// The date start.
        /// </param>
        /// <param name="dateEnd">
        /// The date end.
        /// </param>
        /// <param name="departmentIdCollection">
        /// The department id collection.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetReport(
            string reportName, 
            DateTime dateStart, 
            DateTime dateEnd, 
            List<int> departmentIdCollection)
        {
            return this.reportProcessor.GetReport(reportName, dateStart, dateEnd, departmentIdCollection);
        }

        /// <summary>
        /// The system enter.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <returns>
        /// The <see cref="MemberInfo"/>.
        /// </returns>
        public MemberInfo SystemEnter(string login, string password)
        {
            return this.systemEnterProcessor.SystemEnter(login, password);
        }

        public MemberInfo MemberInfo { get; private set; }

        /// <summary>
        /// Gets the connection error.
        /// </summary>
        public string ConnectionError { get; private set; }

        /// <summary>
        /// Gets a value indicating whether is disconnected.
        /// </summary>
        public bool IsDisconnected { get; private set; }

        /// <summary>
        /// The connect.
        /// </summary>
        /// <param name="serviceUrl">
        /// The service url.
        /// </param>
        public void Connect(string serviceUrl)
        {
            this.systemConnectionProcessor.Connect(serviceUrl);
        }

        /// <summary>
        ///     The disconnect.
        /// </summary>
        public void Disconnect()
        {
            this.systemConnectionProcessor.Disconnect();
        }
    }
}