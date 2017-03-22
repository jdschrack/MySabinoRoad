using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace MySabinoRoad
{

    public class RockApi
    {
        public HttpClient Client;
        public HttpClientHandler Handler;
        public CookieContainer Cookies;

        internal Uri baseAddress = new Uri("");
        public HttpClient CreateClient()
        {
            Handler = new HttpClientHandler();
            var client = new HttpClient(Handler);
            Cookies = new CookieContainer();
            Handler.CookieContainer = Cookies;

            client.BaseAddress = baseAddress;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization-Token", "");

            Client = client;

			RockService.Client = client;
			RockService.Handler = Handler;
			RockService.Cookies = Cookies;

                        
            return Client;
        }

        public RockApi()
        {

        }


		/// <summary>
		/// Once a user logs into the system and we retrieve their context we need to clean up and force API token security.  
		/// This will clear the client, handler, and cookies to allow for a new creation.
		/// </summary>
		public void CleanUpClient()
		{
			this.Client = null;
			this.Handler = null;
			this.Cookies = null;

			RockService.Client = new HttpClient();
			RockService.Cookies = new CookieContainer();
			RockService.Handler = new HttpClientHandler();
		}
    }

    public static class RockService
    {
        public static HttpClient Client;
        public static HttpClientHandler Handler;
        public static CookieContainer Cookies;
        public static bool IsAuthenticated;
    }
}
