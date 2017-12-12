using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.Diagnostics;

namespace InclassOne
{
    public class EditContactPage : ContentPage
    {
        

        public EditContactPage(Contact selectedContact)
        {

            
            EntryCell firstName = new EntryCell { Label = "First Name:", Keyboard = Keyboard.Default, Text = selectedContact.FirstName };
            EntryCell lastName = new EntryCell { Label = "Last Name:", Keyboard = Keyboard.Default, Text = selectedContact.LastName };
            EntryCell contactType = new EntryCell { Label = "Contact Type:", Keyboard = Keyboard.Default, Text = selectedContact.ContactType };
            Label firstLabel = new Label { Text = "", FontSize = 10, FontAttributes = FontAttributes.Bold | FontAttributes.Italic, HorizontalOptions = LayoutOptions.CenterAndExpand };
            Label secondLabel = new Label { Text = "", FontSize = 10, FontAttributes = FontAttributes.Bold | FontAttributes.Italic, HorizontalOptions = LayoutOptions.CenterAndExpand };
            TableView tableView = new TableView
            {
                VerticalOptions = LayoutOptions.Start,
                Intent = TableIntent.Form,
                Root = new TableRoot("Table Title") {
                    new TableSection ("Edit/Delete a Contact") {
                        firstName,
                        lastName,
                        contactType
                    }
                }
            };

            // Setup buttons
            Button saveContactButton = new Button { Text = "Save Contact", WidthRequest = 150, Margin = new Thickness(0, 0, 0, 0) };
            saveContactButton.Clicked += saveContactButtonClicked;
            Button deleteContactButton = new Button { Text = "Delete Contact", WidthRequest = 150, Margin = new Thickness(30, 0, 30, 0) };
            deleteContactButton.Clicked += deleteContactButtonClicked;
            Button cancelButton = new Button { Text = "Cancel", WidthRequest = 150, Margin = new Thickness(0, 0, 0, 0) };
            cancelButton.Clicked += cancelButtonClicked;

            StackLayout buttonLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    saveContactButton,
                    deleteContactButton,
                    cancelButton
                }
            };

            Content = new StackLayout { Children = { tableView, buttonLayout, firstLabel, secondLabel } };

            async void saveContactButtonClicked(object sender, EventArgs e)
            {
                try
                {
                    await App.Database.UpdateContact(selectedContact.ID, firstName.Text.ToString(), lastName.Text.ToString(), contactType.Text.ToString());
                    await Navigation.PopAsync();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception: {0}", ex);
                }
            };

            void cancelButtonClicked(object sender, EventArgs e)
            {
                Navigation.PopAsync();
            };

            async void deleteContactButtonClicked(object sender, EventArgs e)
            {
                bool answer = await DisplayAlert("Delete", "Do you want to delete this contact?", "Yes", "No");
                if (answer)
                {
                    await App.Database.DeleteContactAsync(selectedContact);
                    Navigation.PopAsync();
                }
            };
            
        }
    }
}