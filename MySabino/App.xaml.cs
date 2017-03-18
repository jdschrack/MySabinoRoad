using Xamarin.Forms;

namespace MySabino
{
    public partial class App : Application
    {
        internal static bool IsUserLoggedIn = false;

		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new NavPage());
		}
    }
}
