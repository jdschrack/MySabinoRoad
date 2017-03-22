using Xamarin.Forms;
using System;
using MySabinoRoad.Model;

namespace MySabinoRoad
{
    public partial class MySabinoPage : ContentPage
    {
        public MySabinoPage()
        {
            InitializeComponent();
        }


        public async void btnLogin_Clicked(object sender, EventArgs e)
        {
            var user = new LoginParameters();
            user.Username = userNameEntry.Text;
            user.Password = passwordEntry.Text;
            user.Persisted = true;

            Login login = new Login();

            if (!login.Authenticate(user))
            {
                App.IsUserLoggedIn = false;
                statusLabel.Text = "Login Failed Please Try Again";
                passwordEntry.Text = string.Empty;
                statusLabel.TextColor = Color.Red;
            }
            else
            {
				App.CurrentPerson = await Rock.People.GetCurrentPerson();

                if (Device.OS == TargetPlatform.iOS)
                {
                    await Navigation.PopToRootAsync();
                }
				Application.Current.MainPage = new NavPage();
            }
        }
    }
}
