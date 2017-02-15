// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DashboardControl.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   Interaction logic for DashboardControl.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Client.UI.Control
{
    using System.Windows;
    using System.Windows.Controls;

    using XMIS.Report.Client.UI.ViewModel;

    /// <summary>
    ///     Interaction logic for DashboardControl.xaml
    /// </summary>
    public partial class DashboardControl : UserControl
    {
        /// <summary>
        ///     The dashboard view model property.
        /// </summary>
        public static readonly DependencyProperty DashboardViewModelProperty =
            DependencyProperty.Register(
                "DashboardViewModel", 
                typeof(DashboardViewModel), 
                typeof(DashboardControl), 
                new UIPropertyMetadata(null));

        /// <summary>
        ///     Initializes a new instance of the <see cref="DashboardControl" /> class.
        /// </summary>
        public DashboardControl()
        {
            this.InitializeComponent();
            this.DashboardViewModel = new DashboardViewModel();
            this.DataContext = this.DashboardViewModel;
        }

        /// <summary>
        ///     Gets or sets the dashboard view model.
        /// </summary>
        public DashboardViewModel DashboardViewModel
        {
            get
            {
                return (DashboardViewModel)this.GetValue(DashboardViewModelProperty);
            }

            set
            {
                this.SetValue(DashboardViewModelProperty, value);
            }
        }
    }
}