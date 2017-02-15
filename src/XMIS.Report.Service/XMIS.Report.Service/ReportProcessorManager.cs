// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The report processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Xsl;

    using XMIS.Report.Domain;
    using XMIS.Report.Service.ConfigDataManager;
    using XMIS.Report.Service.Contract;
    using XMIS.Report.Service.Converters;

    /// <summary>
    ///     The report processor.
    /// </summary>
    public class ReportProcessorManager
    {
        /// <summary>
        ///     The accordance template form dictionary.
        /// </summary>
        private readonly IDictionary<string, string> accordanceTemplateFormDictionary;

        /// <summary>
        ///     The department collection.
        /// </summary>
        private readonly IList<DepartmentInfo> departmentCollection;

        /// <summary>
        ///     The department manager.
        /// </summary>
        private readonly DepartmentManager departmentManager;

        /// <summary>
        ///     The hospitalization data manager.
        /// </summary>
        private IHospitalizationDataManager hospitalizationDataManager;

        /// <summary>
        ///     The query processor manager.
        /// </summary>
        private QueryProcessorManager queryProcessorManager;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ReportProcessorManager" /> class.
        /// </summary>
        public ReportProcessorManager()
        {
            this.accordanceTemplateFormDictionary = new Dictionary<string, string>();
            this.InitializeTemplateForm();
            this.departmentManager = new DepartmentManager();
            this.departmentCollection = this.departmentManager.GetDepartmentCollection();
        }

        /// <summary>
        /// The get fill xml report.
        /// </summary>
        /// <param name="reportName">
        /// The report name.
        /// </param>
        /// <param name="startDateTime">
        /// The start date time.
        /// </param>
        /// <param name="endDateTime">
        /// The end date time.
        /// </param>
        /// <param name="departmentIdCollection">
        /// The department id collection.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetFillXmlReport(
            string reportName, 
            DateTime startDateTime, 
            DateTime endDateTime, 
            List<int> departmentIdCollection)
        {
           //   this.hospitalizationDataManager = DalManagerFactory.CreateHospitalizationDataManager("stub");
            this.hospitalizationDataManager = DalManagerFactory.CreateHospitalizationDataManager("default");

            this.queryProcessorManager = new QueryProcessorManager(this.hospitalizationDataManager);

            var dataTable = this.queryProcessorManager.DoQuery(
                reportName, 
                startDateTime, 
                endDateTime, 
                departmentIdCollection);

            var xmlData = DataTableToXMLConverter.ConvertDataTableToXML(dataTable);
            string resultReport = null;

            // XDocument dataReport = XDocument.Parse(xmlData);
            // string dataForFormFileName = reportName + ".data" + ".xml";

            // dataReport.Save(dataForFormFileName);
            // var outputFormFileName = reportName + ".output" + ".xml";
            var hospital = "Больница № 6";

            var reportNameBuilder = new StringBuilder();
            foreach (var departmentId in departmentIdCollection)
            {
                var departmentInfo = this.departmentCollection.FirstOrDefault(d => d.DepartmentId == departmentId);
                reportNameBuilder.Append(departmentInfo.DepartmentName + ", ");
            }

            reportNameBuilder.Length -= 2;
            var departmentNameCollection = reportNameBuilder.ToString();

            if (this.accordanceTemplateFormDictionary.ContainsKey(reportName))
            {
                resultReport = this.DoTransformWithArg(
                    this.accordanceTemplateFormDictionary[reportName], 
                    xmlData, 
                    startDateTime, 
                    endDateTime, 
                    departmentNameCollection, 
                    hospital);
            }

            return resultReport;
        }

        /// <summary>
        ///     The initialize template form.
        /// </summary>
        private void InitializeTemplateForm()
        {
            var path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, 
                @"../../../XMIS.Report.Service/ReportTemplate/");

            this.accordanceTemplateFormDictionary.Add("form7", path + "form7.xsl");
            this.accordanceTemplateFormDictionary.Add("form16", path + "form16.xsl");
        }

        /// <summary>
        /// The do transform with arg.
        /// </summary>
        /// <param name="templateXslFileName">
        /// The template xsl file name.
        /// </param>
        /// <param name="inputXmlData">
        /// The input xml data.
        /// </param>
        /// <param name="dateStart">
        /// The date start.
        /// </param>
        /// <param name="dateEnd">
        /// The date end.
        /// </param>
        /// <param name="departmentCollection">
        /// The department collection.
        /// </param>
        /// <param name="hospital">
        /// The hospital.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string DoTransformWithArg(
            string templateXslFileName, 
            string inputXmlData, 
            DateTime dateStart, 
            DateTime dateEnd, 
            string departmentCollection, 
            string hospital)
        {
            var transformer = new XslCompiledTransform();
            var arg = new XsltArgumentList();
            string resultXml;

            arg.AddParam("startDate", string.Empty, dateStart.ToString("dd.MM.yyyy"));

                // ToShortDateString().ToString(CultureInfo.CurrentCulture));
            arg.AddParam("endDate", string.Empty, dateEnd.ToString("dd.MM.yyyy"));

                // ToShortDateString().ToString(CultureInfo.CurrentCulture));
            arg.AddParam("hospital", string.Empty, hospital);
            arg.AddParam("departmentCollection", string.Empty, departmentCollection);
            transformer.Load(templateXslFileName);
            using (var stringReader = new StringReader(inputXmlData))
            {
                using (var xmlReader = XmlReader.Create(stringReader))
                {
                    using (var stringWriter = new StringWriter())
                    {
                        transformer.Transform(xmlReader, arg, stringWriter);
                        resultXml = stringWriter.ToString();
                    }
                }
            }

            return resultXml;
        }
    }
}