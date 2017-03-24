using MySabinoRoad.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace MySabinoRoad.Rock
{
	public class People
	{
		public static async Task<Person> GetCurrentPerson()
		{
			var client = RockService.Client;

			var person = new Person();
			var response = await client.GetAsync("People/GetCurrentPerson");

			using (HttpContent content = response.Content)
			{
				var result = content.ReadAsStringAsync();
				var settings = new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore,
					MissingMemberHandling = MissingMemberHandling.Ignore
				};

				person = JsonConvert.DeserializeObject<Person>(await result, settings);
			}
			///We need to keep the current person context for other reasons and not pull it every time it is used.

			return person;
		}

		public static async Task<List<Person>> GetAllDirectory()
		{
			RockApi rapi = new RockApi();
			rapi.CleanUpClient();

			if (App.IsUserLoggedIn)
			{
				rapi = new RockApi();
				if (rapi.Client == null)
				{
					rapi.Client = rapi.CreateClient();
				}
			}

			var querystring = "People/DataView/8";

			var response = rapi.Client.GetAsync(querystring).Result;

			var settings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore,
				MissingMemberHandling = MissingMemberHandling.Ignore
			};

			var reader = await response.Content.ReadAsStringAsync();
			var jsonResult = JsonConvert.DeserializeObject<List<Person>>(reader, settings);

			return jsonResult;
		}

		public static async Task<Person> GetPerson(int personId)
		{
			RockApi rapi = new RockApi();
			rapi.CleanUpClient();

			if (App.IsUserLoggedIn)
			{
				rapi = new RockApi();
				if (rapi.Client == null)
				{
					rapi.Client = rapi.CreateClient();
				}
			}

			var client = rapi.Client;

			var person = new Person();
			var response = await client.GetAsync(string.Format("People/{0}", personId));

			using (HttpContent content = response.Content)
			{
				var result = content.ReadAsStringAsync();
				var settings = new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore,
					MissingMemberHandling = MissingMemberHandling.Ignore
				};

				person = JsonConvert.DeserializeObject<Person>(await result, settings);
			}

			return person;
		}

		public static async Task<Person> GetFromContext(int personId)
		{
			RockApi rapi = new RockApi();
			rapi.CleanUpClient();

			if (App.IsUserLoggedIn)
			{
				rapi = new RockApi();
				if (rapi.Client == null)
				{
					rapi.Client = rapi.CreateClient();
				}
			}

			var client = rapi.Client;

			var person = new Person();

			var httpRequestMessage = new HttpRequestMessage(HttpMethod.Options, string.Format("People/SetContext/{0}", personId));

			var response = await client.SendAsync(httpRequestMessage);
			var responseCookies = rapi.Cookies.GetCookies(rapi.baseAddress).Cast<Cookie>();


			var personResponse = await client.GetAsync("People/GetCurrentPerson");

			using (var content = personResponse.Content)
			{
				var result = content.ReadAsStringAsync();
				var settings = new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore,
					MissingMemberHandling = MissingMemberHandling.Ignore
				};

				person = JsonConvert.DeserializeObject<Person>(await result, settings);

			}

			rapi.CleanUpClient();
			rapi = new RockApi();

			return person;

		}
	}
}