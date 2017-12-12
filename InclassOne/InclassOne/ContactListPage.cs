using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;
using System.Threading.Tasks;

namespace InclassOne
{
    public class ContactListPage : ContentPage
    {
        //public ListView listView = new ListView();
        //public List<Contact> contacts { get; set; }
        //public int selectedIndex { get; set; }
        //public ContactDatabase _database;
        public ListView _contactList;
        public int selectedID;
        public ContactListPage()
        {
            //_database = database;
            //var db = SQLiteConnection;

            
            
            _contactList = new ListView();
            //_contactList.ItemsSource = contacts;
            
            _contactList.ItemTemplate = new DataTemplate(typeof(TextCell));
            _contactList.ItemTemplate.SetBinding(TextCell.TextProperty, "FullName");
            _contactList.ItemTemplate.SetBinding(TextCell.DetailProperty, "ContactType");

            Button button = new Button
            {
                Text = "Add Contact",
                Margin = new Thickness(0, 0, 10, 0)
            };
            button.Clicked += OnButtonClicked;

            StackLayout buttonLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label {Text = "Contact List", FontSize = 30, FontAttributes = FontAttributes.Bold | FontAttributes.Italic, Margin = new Thickness(10,0,0,0)},
                    new Label {Text = "", FontSize = 30, FontAttributes = FontAttributes.Bold | FontAttributes.Italic, HorizontalOptions = LayoutOptions.CenterAndExpand},
                    button
                }
            };

            // Add things to the stacklayout
            StackLayout layout = new StackLayout();
            layout.Children.Add(buttonLayout);
            layout.Children.Add(_contactList);
            Content = layout;

            _contactList.ItemTapped += (object sender, ItemTappedEventArgs e) =>
            {
                if (e.Item != null)
                {
                    Contact selectedContact = (e.Item as Contact);
                    
                    Navigation.PushAsync(new EditContactPage(selectedContact));
                }
            };

            void OnButtonClicked(object sender, EventArgs args)
            {
                Navigation.PushAsync(new NewContactPage());
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            _contactList.ItemsSource = await App.Database.GetContactsAsync();
        }

    }
}