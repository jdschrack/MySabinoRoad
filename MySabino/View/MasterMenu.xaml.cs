using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MySabinoRoad.ModelView;

namespace MySabinoRoad.View
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMenu : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterMenu()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterMenuItem>();

            masterPageItems.Add(new MasterMenuItem
            {
                Title = "Contacts",
                IconSource = "contacts.png",
                TargetType = typeof(MasterMenuItem)
            });
            masterPageItems.Add(new MasterMenuItem
            {
                Title = "TodoList",
                IconSource = "todo.png",
                TargetType = typeof(MasterMenuItem)
            });
            masterPageItems.Add(new MasterMenuItem
            {
                Title = "Reminders",
                IconSource = "reminders.png",
                TargetType = typeof(MasterMenuItem)
            });
        }
    }
}
