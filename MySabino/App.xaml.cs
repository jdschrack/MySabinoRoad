using Xamarin.Forms;

namespace MySabino
{
	public partial class App : Application
	{
        internal static bool IsUserLoggedIn = false;
		public App()
		{
			InitializeComponent();

			MainPage = new MySabinoPage();
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
