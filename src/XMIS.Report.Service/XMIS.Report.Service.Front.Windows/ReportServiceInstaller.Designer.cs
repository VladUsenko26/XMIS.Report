namespace XMIS.Report.Service.Front.Windows
{
    using System.Configuration.Install;
    using System.ServiceProcess;

    partial class ReportServiceInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstaller = new ServiceProcessInstaller();
            this.serviceInstaller = new ServiceInstaller();

            //
            // serviceProcessInstaller
            //
            this.serviceProcessInstaller.Password = null;
            this.serviceProcessInstaller.Username = null;
            this.serviceProcessInstaller.Account = ServiceAccount.LocalService;
            //
            // serviceInstaller
            //
            this.serviceInstaller.ServiceName = "XMIS.Report.ReportService";
            this.serviceInstaller.StartType = ServiceStartMode.Automatic;
            //
            //ProjectInstaller
            //
            this.Installers.AddRange(new Installer[]
                                         {
                                             this.serviceProcessInstaller,
                                             this.serviceInstaller
                                         });

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller;

        private System.ServiceProcess.ServiceInstaller serviceInstaller;
    }
}
