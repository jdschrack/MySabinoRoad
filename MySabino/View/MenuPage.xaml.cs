using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MySabinoRoad
{
	
	public partial class MenuPage : ContentPage
	{
		public ListView ListView { get { return listView; } }
			
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

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Home",
				TargetType = typeof(NavPageDetail)
			});

			masterPageItems.Add(new MasterPageItem { 
				Title = "Directory",
				TargetType = typeof(Directory)
			});



			listView.ItemsSource = masterPageItems;
		}

		public class MasterPageItem
		{
			public string Title { get; set; }

			public Type TargetType { get; set; }
		}
	}
}
