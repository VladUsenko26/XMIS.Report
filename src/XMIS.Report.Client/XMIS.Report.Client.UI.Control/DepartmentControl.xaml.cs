// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DepartmentControl.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   Interaction logic for DepartmentControl.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Client.UI.Control
{
    using System.Windows.Controls;

    /// <summary>
    ///     Interaction logic for DepartmentControl.xaml
    /// </summary>
    public partial class DepartmentControl : UserControl
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DepartmentControl" /> class.
        ///     Gets or sets the department view model.
        /// </summary>
        /// <summary>
        ///     Initializes a new instance of the <see cref="DepartmentControl" /> class.
        /// </summary>
        public DepartmentControl()
        {
            // DepartmentViewModel root = this.DepartmentTree.Items[0] as DepartmentViewModel;
            // this.DepartmentViewModel = new DepartmentViewModel();

            // this.DataContext = this.DepartmentViewModel;
            this.InitializeComponent();
        }
    }
}