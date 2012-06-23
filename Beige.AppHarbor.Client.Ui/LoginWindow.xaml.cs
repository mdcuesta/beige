using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Beige.AppHarbor.Client;

namespace Beige.AppHarbor.Client.Ui
{
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public string AccessToken { get; set; }

        public LoginWindow()
        {
            InitializeComponent();
            Title = "AppHarbor Login";
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var accessToken = Authenticator.Authenticate(txtUsername.Text, txtPassword.SecurePassword.ToString());
            if (string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show(this, "Invalid Username or Password");
                return;
            }

            AccessToken = accessToken;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
