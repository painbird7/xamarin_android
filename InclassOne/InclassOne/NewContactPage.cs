using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.Diagnostics;

namespace InclassOne
{
    public class NewContactPage : ContentPage
    {
        public NewContactPage()
        {
            //_parent = parent;
            //_database = database;
            Title = "Add a new contact";

            // Setup tableview
            EntryCell firstName = new EntryCell { Label = "First Name:", Keyboard = Keyboard.Default };
            EntryCell lastName = new EntryCell { Label = "Last Name:", Keyboard = Keyboard.Default };
            EntryCell contactType = new EntryCell { Label = "Contact Type:", Keyboard = Keyboard.Default };
            Label firstLabel = new Label { Text = "", FontSize = 10, FontAttributes = FontAttributes.Bold | FontAttributes.Italic, HorizontalOptions = LayoutOptions.CenterAndExpand };
            Label secondLabel = new Label { Text = "", FontSize = 10, FontAttributes = FontAttributes.Bold | FontAttributes.Italic, HorizontalOptions = LayoutOptions.CenterAndExpand };
            TableView tableView = new TableView
            {
                VerticalOptions = LayoutOptions.Start,
                Intent = TableIntent.Form,
                Root = new TableRoot("Table Title") {
                    new TableSection ("Add a New Contact") {
                        firstName,
                        lastName,
                        contactType
                    }
                }
            };

            // Setup buttons
            Button saveContactButton = new Button { Text = "Save Contact", WidthRequest = 150, Margin = new Thickness(50, 0, 0, 0) };
            saveContactButton.Clicked += saveContactButtonClicked;
          
            Button returnButton = new Button { Text = "Return", WidthRequest = 150, Margin = new Thickness(10, 0, 50, 0) };
            returnButton.Clicked += returnButtonClicked;

            StackLayout buttonLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.Start,
                Children =
                {
                    saveContactButton,
                    new Label {Text = "", FontSize = 30, FontAttributes = FontAttributes.Bold | FontAttributes.Italic, HorizontalOptions = LayoutOptions.CenterAndExpand},
                    returnButton
                }
            };

            Content = new StackLayout { Children = { tableView, buttonLayout, firstLabel, secondLabel } };

            void returnButtonClicked(object sender, EventArgs e)
            {
                Navigation.PopAsync();
            };
            
            async void saveContactButtonClicked(object sender, EventArgs e)
            {
                var newContact = new Contact {
                    FirstName = firstName.Text.ToString(),
                    LastName = lastName.Text.ToString(),
                    ContactType = contactType.Text.ToString()
                };
                await App.Database.SaveContactAsync(newContact);
                firstName.Text = "";
                lastName.Text = "";
                contactType.Text = "";
            };
        }
    }
}