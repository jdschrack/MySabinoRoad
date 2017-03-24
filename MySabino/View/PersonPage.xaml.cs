using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySabinoRoad.Model;
using MySabinoRoad.Rock;
using Xamarin.Forms;

namespace MySabinoRoad
{
	public partial class PersonPage : ContentPage
	{
		public static Person ViewedPerson = new Person();

		public PersonPage(Person selPer)
		{
			
			InitializeComponent();

			GetPersonDetails(selPer.Id);

			var person = ViewedPerson;

			if (person.Photo != null)
			{
				imgUser.Source = ImageSource.FromUri(new Uri(person.Photo.Url));
				imgUser.WidthRequest = 50;
				imgUser.HeightRequest = 50;
				imgUser.Aspect = Aspect.AspectFit;
			}
			else if (person.Gender == 2)
			{
				imgUser.Source = "female.jpg";
				imgUser.WidthRequest = 50;
				imgUser.HeightRequest = 50;
				imgUser.Aspect = Aspect.AspectFit;
			}
			else
			{
				imgUser.Source = "male.jpg";
				imgUser.WidthRequest = 50;
				imgUser.HeightRequest = 50;
				imgUser.Aspect = Aspect.AspectFit;
			}

			personWelcome.Text = string.Format("You are viewing {0} ({1})", selPer.FullName, person.Id.ToString());
		}

		public static async void GetPersonDetails(int id)
		{
			ViewedPerson = await People.GetFromContext(id);


		}
	}
}
