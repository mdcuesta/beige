using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppHarbor;
using AppHarbor.Model;

namespace Beige.AppHarbor.Client
{
    public class ApiClient
    {
        private AppHarborApi _api;

        private string AccessToken { get; set; }

        private AppHarborApi AppHarborApi
        {
            get
            {
                _api = _api ?? new AppHarborApi(new AuthInfo { AccessToken = AccessToken });
                return _api;
            }
        }

        public ApiClient(string accessToken)
        {
            AccessToken = accessToken;
        }

        public CreateResult<string> CreateApplication(string applicationName)
        {
            return AppHarborApi.CreateApplication(applicationName, null);
        }

        public CreateResult<string> CreateApplication(string applicationName, string region)
        {
            return AppHarborApi.CreateApplication(applicationName, region);
        }
    }
}
