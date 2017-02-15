// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFrontServiceClient.cs" company="">
//   
// </copyright>
// <summary>
//   The FrontServiceClient interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.Contract
{
    using System;
    using System.Collections.Generic;

    using XMIS.Report.Client.Domain;

    /// <summary>
    ///     The FrontServiceClient interface.
    /// </summary>
    public interface IFrontServiceClient
    {
        /// <summary>
        /// Gets the connection error.
        /// </summary>
        string ConnectionError { get; }

        /// <summary>
        /// Gets a value indicating whether is disconnected.
        /// </summary>
        bool IsDisconnected { get; }

        /// <summary>
        /// The connect.
        /// </summary>
        /// <param name="serviceUrl">
        /// The service url.
        /// </param>
        void Connect(string serviceUrl);

        /// <summary>
        ///     The disconnect.
        /// </summary>
        void Disconnect();

        /// <summary>
        ///     The get report collection.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        List<ReportInfo> GetReportCollection();

        /// <summary>
        ///     The get department collection.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        List<DepartmentInfo> GetDepartmentCollection();

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
        /// The <see cref="string"/> XML with report.
        /// </returns>
        string GetReport(string reportName, DateTime dateStart, DateTime dateEnd, List<int> departmentIdCollection);

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
        MemberInfo SystemEnter(string login, string password);

        /// <summary>
        /// Gets the member info.
        /// </summary>
        MemberInfo MemberInfo { get; }
    }
}