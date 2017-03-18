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


        private void btnLogin_Clicked(object sender, EventArgs e)
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
        }
    }
}
