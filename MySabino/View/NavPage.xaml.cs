using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySabinoRoad
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavPage : MasterDetailPage
    {
		public NavPage()
		{
			InitializeComponent();
			menuPage.ListView.ItemSelected += OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MenuPage.MasterPageItem;
			if (item != null)
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType))
				{
					BarBackgroundColor = Color.FromHex("#c2b8a7"),
					BarTextColor = Color.FromHex("#6a6a6a")
				};
				menuPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
    }
}
