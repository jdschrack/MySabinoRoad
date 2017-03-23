using MySabinoRoad.Model;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;

using System.Collections.ObjectModel;

namespace MySabinoRoad
{
    public partial class Directory : ContentPage
    {
        public ObservableCollection<PageTypeGroup<string, Person>> PeopleGrouped = new ObservableCollection<PageTypeGroup<string, Person>>();
        public List<Person> People = new List<Person>();
        public Directory()
        {
            InitializeComponent();
            GetPageDetails();
            this.BindingContext = PeopleGrouped;
            GroupedView2.IsVisible = false;
            GroupedView.ItemsSource = PeopleGrouped;
        }

        public async void GetPageDetails()
        {
            var people = await Rock.People.GetAllDirectory();
            People = people;
            var sorted = from i in people
                         orderby i.LastName
                         group i by i.LastName[0].ToString().ToUpper() into personGroup
                         select new PageTypeGroup<string, Person>(personGroup.Key, personGroup);

            this.PeopleGrouped = new ObservableCollection<PageTypeGroup<string, Person>>(sorted);

        }

        private void FilterContacts(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                GetPageDetails();
                GroupedView2.IsVisible = false;
                GroupedView.ItemsSource = PeopleGrouped;
                GroupedView.IsVisible = true;
            }
            else
            {
                GroupedView2.IsVisible = true;
                GroupedView.IsVisible = false;
                GroupedView2.ItemsSource = People.Where(o => o.FullName.ToLower().Contains(e.NewTextValue.ToLower()));
            }
            
        }
    }

    public class PageTypeGroup<K, Person> : ObservableCollection<Person>
    {
        public K Key { get; private set; }

        public PageTypeGroup(K key, IEnumerable<Person> items)
        {
            Key = key;
            foreach (var item in items)
            {
                this.Items.Add((Person)item);
            }
        }

    }
}