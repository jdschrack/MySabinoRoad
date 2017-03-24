using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MySabinoRoad.Model;
using Newtonsoft.Json;

namespace MySabinoRoad.Rock
{
	public class Family
	{
		public Family()
		{
		}

		public static async Task<FamilySearchResult> GetByPersonId(int personId)
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

			var querystring = string.Format("Groups/GetFamilies/{0}", personId.ToString());

			var response = rapi.Client.GetAsync(querystring).Result;

			var settings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore,
				MissingMemberHandling = MissingMemberHandling.Ignore
			};

			var reader = await response.Content.ReadAsStringAsync();
			var jsonResult = JsonConvert.DeserializeObject<FamilySearchResult>(reader, settings);

			return jsonResult;
		}

		public static async Task<Family> GetFamily(int familyId)
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

			var querystring = string.Format("Groups/GetFamily/{0}", familyId.ToString());

			var response = rapi.Client.GetAsync(querystring).Result;

			var settings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore,
				MissingMemberHandling = MissingMemberHandling.Ignore
			};

			var reader = await response.Content.ReadAsStringAsync();
			var jsonResult = JsonConvert.DeserializeObject<Family>(reader, settings);

			return jsonResult;
		}
	}
}
