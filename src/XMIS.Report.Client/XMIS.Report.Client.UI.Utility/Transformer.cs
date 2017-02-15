// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Transformer.cs" company="">
//   
// </copyright>
// <summary>
//   The transformer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Client.UI.Utility
{
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    ///     The transformer.
    /// </summary>
    public class Transformer
    {
        /// <summary>
        /// The open report with excel.
        /// </summary>
        /// <param name="workbookPath">
        /// The workbook path.
        /// </param>
        public static void OpenReportWithExcel(string workbookPath)
        {
            // Open the XML file in Excel.
            var excelApp = new Application();
            excelApp.Visible = true;

            var excelWorkbook = excelApp.Workbooks.Open(
                workbookPath, 
                0, 
                false, 
                5, 
                string.Empty, 
                string.Empty, 
                false, 
                XlPlatform.xlWindows, 
                string.Empty, 
                true, 
                false, 
                0, 
                true, 
                false, 
                false);

            /*
             * WorkBooks.open(string Filename, object UpdateLinks, object ReadOnly, object Format, 
             * object Password, object WriteResPassword, object ReadOnlyRecommend, object Origin, 
             * object Delimiter, object Editable, object Notify, object Converter, object AddToMru, 
             * object Local, object CorruptLoad )
             */
        }
    }
}