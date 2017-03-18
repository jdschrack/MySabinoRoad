using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using MySabino.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MySabino
{
    /// <summary>
    /// Function to authenticate with web service.
    /// </summary>
    public class Login
	{
        internal bool Authenticate(LoginParameters user)
        {
            bool isLoggedIn = false;

            var json = JsonConvert.SerializeObject(user);

            RockApi rockApi = new RockApi();

            var client = new HttpClient();

            if (rockApi.Client == null)
            {
                rockApi.Client = rockApi.CreateClient();
            }

            client = rockApi.Client;

            StringContent query = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
            var response = new HttpResponseMessage();

            response = client.PostAsync("auth/login", query).Result;

            var responseCookies = rockApi.Cookies.GetCookies(rockApi.baseAddress).Cast<Cookie>();

            if (response.IsSuccessStatusCode)
            {
                isLoggedIn = true;

                RockService.Client = client;
                RockService.Handler = rockApi.Handler;
                RockService.Cookies = rockApi.Cookies;
                RockService.IsAuthenticated = true;
            }

			App.IsUserLoggedIn = isLoggedIn;

            return isLoggedIn;
        }
    }
}
