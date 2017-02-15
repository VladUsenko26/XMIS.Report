// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   The login view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Client.UI.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Input;

    using XMIS.Report.Client.Context;
    using XMIS.Report.Client.UI.Utility;
    using XMIS.Report.Service.Front.Client.Contract;
    using XMIS.Report.Service.Front.Client.Stub;

    /// <summary>
    ///     The login view model.
    /// </summary>
    public class LoginViewModel : ViewModelBase
    {
        /// <summary>
        ///     The login name property.
        /// </summary>
        public static readonly DependencyProperty LoginNameProperty = DependencyProperty.Register(
            "LoginName", 
            typeof(string), 
            typeof(LoginViewModel), 
            new UIPropertyMetadata(null));

        /// <summary>
        ///     The password property.
        /// </summary>
        public static readonly DependencyProperty PasswordProperty = DependencyProperty.Register(
            "Password", 
            typeof(string), 
            typeof(LoginViewModel), 
            new UIPropertyMetadata(null));

        /// <summary>
        ///     The front service client.
        /// </summary>
        private readonly IFrontServiceClient frontServiceClient;

        /// <summary>
        ///     The validated properties.
        /// </summary>
        private readonly List<string> ValidatedProperties = new List<string> { "LoginName", "Password" };

        /// <summary>
        ///     The login command.
        /// </summary>
        private RelayCommand loginCommand;

        /// <summary>
        ///     Initializes a new instance of the <see cref="LoginViewModel" /> class.
        /// </summary>
        public LoginViewModel()
        {
            // for stub
            this.frontServiceClient = new FrontServiceClientStub();

            // this.frontServiceClient = new FrontServiceClient();
        }

        /// <summary>
        ///     Gets or sets the login name.
        /// </summary>
        public string LoginName
        {
            get
            {
                return (string)this.GetValue(LoginNameProperty);
            }

            set
            {
                this.SetValue(LoginNameProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets the password.
        /// </summary>
        public string Password
        {
            get
            {
                return (string)this.GetValue(PasswordProperty);
            }

            set
            {
                this.SetValue(PasswordProperty, value);
            }
        }

        /// <summary>
        ///     Gets the login command.
        /// </summary>
        public ICommand LoginCommand
        {
            get
            {
                if (this.loginCommand == null)
                {
                    this.loginCommand = new RelayCommand(param => this.Login(), param => this.CanLogin);
                }

                return this.loginCommand;
            }
        }

        /// <summary>
        ///     Gets a value indicating whether can login.
        /// </summary>
        private bool CanLogin
        {
            get
            {
                return this.Validate;
            }
        }

        /// <summary>
        ///     Gets a value indicating whether validate.
        /// </summary>
        private bool Validate
        {
            get
            {
                foreach (var property in this.ValidatedProperties)
                {
                    if (this.GetValidationError(property) != null)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        /// <summary>
        ///     The login.
        /// </summary>
        /// <exception cref="Exception">
        /// </exception>
        private void Login()
        {
            try
            {
                // MemberInfo memberInfo = new MemberInfo();
                // memberInfo = this.frontServiceClient.SystemEnter(this.LoginName, this.Password);
                if (this.LoginName == "dev" && this.Password == "dev")
                {
                    // if (memberInfo != null)
                    ControlManager.GetInstance().Place("MainWindow", "mainRegion", "DashboardControl");
                }
                else
                {
                    throw new Exception("Not valid login or password. Try again!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// The get validation error.
        /// </summary>
        /// <param name="property">
        /// The property.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string GetValidationError(string property)
        {
            string error = null;
            switch (property)
            {
                case "LoginName":
                    error = this.ValidateLogin();
                    break;
                case "Password":
                    error = this.ValidatePassword();
                    break;
                default:
                    break;
            }

            return error;
        }

        /// <summary>
        ///     The validate password.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        private string ValidatePassword()
        {
            string error = null;
            if (string.IsNullOrEmpty(this.Password))
            {
                error = "Please, enter password.";
            }

            // if (this.Password.Contains(" "))
            // {
            // error = "Blank characters are not allowed in password.";
            // }
            return error;
        }

        /// <summary>
        ///     The validate login.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        private string ValidateLogin()
        {
            string error = null;
            if (string.IsNullOrEmpty(this.LoginName))
            {
                error = "Please, enter login.";
            }

            // if (this.LoginName.Contains(" "))
            // {
            // error = "Blank characters are not allowed in login.";
            // }
            return error;
        }
    }
}