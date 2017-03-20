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
				imgUser.Source = ImageSource.FromUri(new Uri(person.Photo.Url));
				imgUser.WidthRequest = 90;
				imgUser.HeightRequest = 90;
				imgUser.Aspect = Aspect.AspectFit;
			}
			else if (person.Gender == 2)
			{
				imgUser.Source = "female.jpg";
				imgUser.WidthRequest = 90;
				imgUser.HeightRequest = 90;
				imgUser.Aspect = Aspect.AspectFit; 
			}
			else
			{
				imgUser.Source = "male.jpg";
				imgUser.WidthRequest = 90;
				imgUser.HeightRequest = 90;
				imgUser.Aspect = Aspect.AspectFit;
			}
		}


	}
}
