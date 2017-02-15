// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginControl.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   Interaction logic for LoginControl.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Client.UI.Control
{
    using System.Windows;
    using System.Windows.Controls;

    using XMIS.Report.Client.UI.ViewModel;

    /// <summary>
    ///     Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        /// <summary>
        ///     The login view model property.
        /// </summary>
        public static readonly DependencyProperty LoginViewModelProperty = DependencyProperty.Register(
            "LoginViewModel", 
            typeof(LoginViewModel), 
            typeof(LoginControl), 
            new UIPropertyMetadata(null));

        /// <summary>
        ///     Initializes a new instance of the <see cref="LoginControl" /> class.
        /// </summary>
        public LoginControl()
        {
            this.InitializeComponent();
            this.LoginViewModel = new LoginViewModel();
            this.DataContext = this.LoginViewModel;
        }

        /// <summary>
        ///     Gets or sets the login view model.
        /// </summary>
        public LoginViewModel LoginViewModel
        {
            get
            {
                return (LoginViewModel)this.GetValue(LoginViewModelProperty);
            }

            set
            {
                this.SetValue(LoginViewModelProperty, value);
            }
        }
    }
}