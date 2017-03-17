using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace MySabino.Model
{
    internal class Login
    {
        
        internal static bool Authenticate(LoginParameters user)
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
            }

            return isLoggedIn;
        }
    }
    public class LoginParameters
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>

        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>

        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="LoginParameters"/> information is going to be persisted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if persisted; otherwise, <c>false</c>.
        /// </value>

        public bool Persisted { get; set; }


    }
}
