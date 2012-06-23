using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beige.AppHarbor.Client.Ui
{
    public sealed class Helper
    {
        public static string GetAccessToken()
        {
            var loginControl = new LoginWindow();
            loginControl.ShowDialog();
            return loginControl.AccessToken;
        }
    }
}
