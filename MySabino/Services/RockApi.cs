using RestSharp.Portable;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace MySabino
{

	public static class RockApi
	{
		const string AuthorizationTokenHeaderKey = "Authorization-Token";

		public static string BaseUrl { get; private set; }
		static string AuthorizationKey { get; set; }
		static HttpWebRequest Request { get; set; }
		static RockApi()
		{
			//Request = new HttpWebRequest();
		}
	}
}
