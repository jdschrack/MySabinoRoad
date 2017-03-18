using Xamarin.Forms;

namespace MySabino
{
    public partial class App : Application
    {
        internal static bool IsUserLoggedIn = false;
        public App()
        {
            InitializeComponent();

            var login = new Login();
            login.PropertyChanged += SingnedIn_PropertyChanged;

            MainPage = new MySabinoPage();
        }

        void SingnedIn_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var login = sender as Login;

            switch (e.PropertyName)
            {
                case "IsSignedIn":
                    {
                        if (login.IsSignedIn)
                        {
                            MainPage = new View.MainPage();
                        }
                        else
                        {
                            if (!(MainPage is MySabinoPage))
                            {
                                MainPage = new MySabinoPage();
                            }
                        }
                        break;
                    }

            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
