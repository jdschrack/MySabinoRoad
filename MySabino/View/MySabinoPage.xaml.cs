using Xamarin.Forms;
using System;
using MySabino.Model;

namespace MySabino
{
	public partial class MySabinoPage : ContentPage
	{
		public MySabinoPage()
		{
			InitializeComponent();
		}
         

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            var user = new LoginParameters();
            user.Username = userNameEntry.Text;
            user.Password = passwordEntry.Text;
            user.Persisted = true;

            if (Login.Authenticate(user))
            {
                App.IsUserLoggedIn = true;
                statusLabel.Text = "Yay You Logged In";
                statusLabel.TextColor = Color.Green;
            }
            else
            {
                App.IsUserLoggedIn = false;
                statusLabel.Text = "Login Failed Please Try Again";
                passwordEntry.Text = string.Empty;
            }
        }
    }
}
