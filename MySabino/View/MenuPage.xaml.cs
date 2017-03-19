using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MySabinoRoad.View
{
	public partial class MenuPage : ContentPage
	{
		public MenuPage()
		{
			InitializeComponent();

			var person = App.CurrentPerson;
			txtUser.Text = person.FullName;

			if (person.Photo != null)
			{
				imgUser.Source = person.Photo.Url;
			}
			else
			{
				imgUser.Source = "https://sabinoroad.org/Assets/Images/person-no-photo-male.svg?&height=80&width=80&mode=crop&scale=both";
			}
		}


	}
}
