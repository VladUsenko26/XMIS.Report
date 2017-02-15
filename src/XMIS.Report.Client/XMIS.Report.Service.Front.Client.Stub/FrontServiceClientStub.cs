// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FrontServiceClientStub.cs" company="">
//   
// </copyright>
// <summary>
//   The front service client stub.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.Stub
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using XMIS.Report.Client.Domain;
    using XMIS.Report.Service.Front.Client.Contract;

    /// <summary>
    ///     The front service client stub.
    /// </summary>
    public class FrontServiceClientStub : IFrontServiceClient
    {
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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void Connect(string serviceUrl)
        {
        }

        /// <summary>
        ///     The disconnect.
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void Disconnect()
        {
        }

        /// <summary>
        ///     The get report collection.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<ReportInfo> GetReportCollection()
        {
            return new List<ReportInfo>
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
                               }
                       };
        }

        /// <summary>
        ///     The get department collection.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public List<DepartmentInfo> GetDepartmentCollection()
        {
            throw new NotImplementedException();
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
            // string xml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?><Items><Item><Item1>1</Item1><Item22>2</Item22><Item3>3</Item3></Item></Items>";
            string xml;
            using (
                var streamReader = new StreamReader(
                    @"..\..\..\XMIS.Report.Service.Front.Client.Stub\reportXML.txt", 
                    Encoding.Default))
            {
                xml = streamReader.ReadToEnd();
            }

            return xml;
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
            var memberInfo = new MemberInfo();

            if (login == "dev" && password == "dev")
            {
                memberInfo.Login = "dev";
                memberInfo.Password = "dev";
            }

            return memberInfo;
        }
        
        /*There was an error*/
        public MemberInfo MemberInfo { get; private set; }
    }
}