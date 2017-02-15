// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DashboardViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   The dashboard view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Client.UI.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Windows;
    using System.Windows.Input;
    using System.Xml.Linq;

    using XMIS.Report.Client.Domain;
    using XMIS.Report.Client.UI.Utility;
    using XMIS.Report.Service.Front.Client.Common;
    using XMIS.Report.Service.Front.Client.Contract;

    /// <summary>
    ///     The dashboard view model.
    /// </summary>
    public class DashboardViewModel : ViewModelBase
    {
        /// <summary>
        ///     The department view model.
        /// </summary>
        private readonly DepartmentViewModel departmentViewModel;

        /// <summary>
        ///     The front service client.
        /// </summary>
        private readonly IFrontServiceClient frontServiceClient;

        /// <summary>
        ///     The print report command.
        /// </summary>
        private RelayCommand printReportCommand;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DashboardViewModel" /> class.
        /// </summary>
        public DashboardViewModel()
        {
            this.departmentViewModel = new DepartmentViewModel();

            // For Stub
            // this.frontServiceClient = new FrontServiceClientStub();

            // For real
            this.frontServiceClient = new FrontServiceClient();
            this.Departments = this.departmentViewModel.CreateDepartments();

            // Connect to server
            var hubConnectionUrl = ConfigurationManager.AppSettings["ServiceUrl"];
            this.frontServiceClient.Connect(hubConnectionUrl);
        }

        /// <summary>
        ///     The print report command.
        /// </summary>
        /// <returns>
        ///     The <see cref="ICommand" />.
        /// </returns>
        public ICommand PrintReportCommand
        {
            get
            {
                if (this.printReportCommand == null)
                {
                    this.printReportCommand = new RelayCommand(
                        param => this.PrintReport(), 
                        param => this.CanPrintReport);
                }

                return this.printReportCommand;
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether can print report.
        /// </summary>
        public bool CanPrintReport
        {
            get
            {
                if ((this.SelectedReport != null) && (this.departmentViewModel.GetCheckedItems().Count != 0))
                {
                    return true;
                }

                return false;
            }
        }

        #region Department

        /// <summary>
        ///     Gets the departments.
        /// </summary>
        public List<DepartmentViewModel> Departments { get; private set; }

        #endregion

        /// <summary>
        ///     The print report.
        /// </summary>
        private void PrintReport()
        {
            try
            {
                var start = new DateTime(
                    this.StartDateTime.Year, 
                    this.StartDateTime.Month, 
                    this.StartDateTime.Day, 
                    8, 
                    0, 
                    0);
                var end = new DateTime(this.EndDateTime.Year, this.EndDateTime.Month, this.EndDateTime.Day, 7, 59, 59);

                var checkedDepartmentItems = this.departmentViewModel.GetCheckedItems();
                var report = this.SelectedReport;
                var departmentIdCollection = new List<int>();
                departmentIdCollection =
                    checkedDepartmentItems.Select(departmentId => departmentId.DepartmentId).ToList();

                var xml = this.frontServiceClient.GetReport(report.ReportName, start, end, departmentIdCollection);

                // client side
                var dataReport = XDocument.Parse(xml);
                var outputFileName = report.ReportName + ".output.[" + start.ToString("dd.MM.yyyy") + "-" + end.ToString("dd.MM.yyyy") + "].xml";
                dataReport.Save(outputFileName);

                var workbookPath = Path.GetFullPath(outputFileName);

                Transformer.OpenReportWithExcel(workbookPath);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        #region DatePicker

        /// <summary>
        ///     Gets or sets the start date time.
        /// </summary>
        public DateTime StartDateTime
        {
            get
            {
                return (DateTime)this.GetValue(StartDateTimeProperty);
            }

            set
            {
                this.SetValue(StartDateTimeProperty, value);
            }
        }

        // Define start and end dateTime
        /// <summary>
        ///     The today.
        /// </summary>
        private static DateTime today = DateTime.Today;

        /// <summary>
        ///     The start date time.
        /// </summary>
        private static readonly DateTime startDateTime = new DateTime(today.Year, today.Month, today.Day, 8, 0, 0);

        /// <summary>
        ///     The end date time.
        /// </summary>
        private static readonly DateTime endDateTime = new DateTime(today.Year, today.Month, today.Day, 7, 59, 59);

        /// <summary>
        ///     The start date time property.
        /// </summary>
        public static readonly DependencyProperty StartDateTimeProperty = DependencyProperty.Register(
            "StartDateTime", 
            typeof(DateTime), 
            typeof(DashboardViewModel), 
            new PropertyMetadata(startDateTime));

        /// <summary>
        ///     Gets or sets the en date time.
        /// </summary>
        public DateTime EndDateTime
        {
            get
            {
                return (DateTime)this.GetValue(EndDateTimeProperty);
            }

            set
            {
                this.SetValue(EndDateTimeProperty, value);
            }
        }

        /// <summary>
        ///     The en date time property.
        /// </summary>
        public static readonly DependencyProperty EndDateTimeProperty = DependencyProperty.Register(
            "EndDateTime", 
            typeof(DateTime), 
            typeof(DashboardViewModel), 
            new PropertyMetadata(endDateTime));

        #endregion DatePicker

        #region Report

        /// <summary>
        ///     Gets the reports.
        /// </summary>
        public List<ReportInfo> Reports
        {
            get
            {
                return this.frontServiceClient.GetReportCollection();
            }
        }

        /// <summary>
        ///     Gets or sets the selected report.
        /// </summary>
        public ReportInfo SelectedReport
        {
            get
            {
                return (ReportInfo)this.GetValue(SelectedReportProperty);
            }

            set
            {
                this.SetValue(SelectedReportProperty, value);
            }
        }

        /// <summary>
        ///     The selected report property.
        /// </summary>
        public static readonly DependencyProperty SelectedReportProperty = DependencyProperty.Register(
            "SelectedReport", 
            typeof(ReportInfo), 
            typeof(DashboardViewModel), 
            new PropertyMetadata(null));

        #endregion Report
    }
}