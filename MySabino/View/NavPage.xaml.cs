using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MySabino
{
	public partial class NavPage : MasterDetailPage
	{
		public NavPage()
		{
			InitializeComponent();

			if (!App.IsUserLoggedIn)
			{
				ShowLogin();
			}
		}

		internal async void ShowLogin()
		{
			var page = new NavigationPage(new MySabinoPage());

			await Navigation.PushModalAsync(page);
		}

	}
}
