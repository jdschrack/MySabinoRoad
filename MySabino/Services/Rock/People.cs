using MySabinoRoad.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MySabinoRoad.Rock
{
	public class People
	{
		public static async Task<Person> GetCurrentPerson()
		{
			var client = RockService.Client;
			var handler = RockService.Handler;
			var cookies = RockService.Cookies;
			var person = new Person();
			var response = await client.GetAsync("People/GetCurrentPerson");

			using (HttpContent content = response.Content)
			{
				var result = content.ReadAsStringAsync();

				person = JsonConvert.DeserializeObject<Person>(await result);
			}
			///We need to keep the current person context for other reasons and not pull it every time it is used.

			return person;
		}
	}
}
