// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTableToXMLConverter.cs" company="">
//   
// </copyright>
// <summary>
//   The data table to xml converter.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XMIS.Report.Service.Converters
{
    using System.Data;
    using System.IO;
    using System.Text;

    /// <summary>
    /// The data table to xml converter.
    /// </summary>
    public class DataTableToXMLConverter
    {
        /// <summary>
        /// This method is used to convert the DataTable into string XML format.
        /// </summary>
        /// <param name="dataTable">
        /// DataTable to be converted.
        /// </param>
        /// <returns>
        /// (string) XML form of the DataTable.
        /// </returns>
        public static string ConvertDataTableToXML(DataTable dataTable)
        {
            var dataSet = new DataSet();
            StringBuilder stringBuilder;
            StringWriter stringWriter;
            string outputXMLString;

            stringBuilder = new StringBuilder();
            stringWriter = new StringWriter(stringBuilder);
            dataSet.Merge(dataTable, true, MissingSchemaAction.AddWithKey);
            dataSet.Tables[0].TableName = "DataItem";
            foreach (DataColumn col in dataSet.Tables[0].Columns)
            {
                col.ColumnMapping = MappingType.Attribute;
            }

            dataSet.WriteXml(stringWriter, XmlWriteMode.WriteSchema);
            outputXMLString = stringBuilder.ToString();
            return outputXMLString;
        }
    }
}