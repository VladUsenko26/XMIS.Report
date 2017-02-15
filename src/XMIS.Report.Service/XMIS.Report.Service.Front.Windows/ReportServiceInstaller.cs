// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportServiceInstaller.cs" company="">
//   
// </copyright>
// <summary>
//   The report service installer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Windows
{
    using System.ComponentModel;
    using System.Configuration.Install;

    /// <summary>
    ///     The report service installer.
    /// </summary>
    [RunInstaller(true)]
    public partial class ReportServiceInstaller : Installer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ReportServiceInstaller" /> class.
        /// </summary>
        public ReportServiceInstaller()
        {
            this.InitializeComponent();
        }
    }
}