// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   Interaction logic for App.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Client.UI
{
    using System;
    using System.Windows;

    using XMIS.Report.Client.Context;
    using XMIS.Report.Client.UI.Control;

    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// The app start up.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="args">
        /// The args.
        /// </param>
        private void AppStartUp(object sender, StartupEventArgs args)
        {
            try
            {
                ControlManager.GetInstance().Add("MainWindow", typeof(MainWindow));
                ControlManager.GetInstance().Add("LoginControl", typeof(LoginControl));
                ControlManager.GetInstance().Add("DashboardControl", typeof(DashboardControl));

                this.MainWindow = ControlManager.GetInstance().GetControl("MainWindow") as MainWindow;
                this.MainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                this.MainWindow.Show();

                ControlManager.GetInstance().Place("MainWindow", "mainRegion", "LoginControl");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// The app exit.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="args">
        /// The args.
        /// </param>
        private void AppExit(object sender, ExitEventArgs args)
        {
            this.Shutdown();
        }
    }
}