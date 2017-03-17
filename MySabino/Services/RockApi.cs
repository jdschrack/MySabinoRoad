using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace MySabino
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

            return Client;
        }

        public RockApi()
        {

        }
    }
}
