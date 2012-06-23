using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using System.Web;

namespace Beige.AppHarbor.Client
{
    public sealed class Authenticator
    {
        public static string Authenticate(string username, string password)
        {
            var restClient = new RestClient("https://appharbor-token-client.apphb.com");
            var request = new RestRequest("/token", Method.POST);           
            request.AddParameter("username", username);
            request.AddParameter("password", password);

            var response = restClient.Execute(request);
            var accessToken = HttpUtility.ParseQueryString(response.Content)["access_token"];
            return accessToken;
        }
    }
}
