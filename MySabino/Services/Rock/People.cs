using MySabinoRoad.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

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
	}
}
