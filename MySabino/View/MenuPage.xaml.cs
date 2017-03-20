using System;
using Xamarin.Forms;

namespace MySabinoRoad
{
	public partial class MenuPage : ContentPage
	{
		public MenuPage()
		{
			InitializeComponent();

			var person = App.CurrentPerson;
			txtUser.Text = person.FullName;
            txtConnectionStatus.Text = person.ConnectionStatusValue.Value;
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
		}


	}
}
