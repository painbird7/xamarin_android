using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
    public class DateTimePickerPage : ContentPage
    {
        public DateTimePickerPage()
        {
            Label date = new Label { Text = DateTime.Today.ToLongDateString() };
            Label time = new Label { Text = DateTime.Now.ToLongTimeString() };
            Label header = new Label
            {
                Text = "Date Picker and Time Picker",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center
            };

            DatePicker datePicker = new DatePicker
            {
                
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            TimePicker timePicker = new TimePicker
            {
                Format = "T",
                VerticalOptions = LayoutOptions.StartAndExpand
            };
            
            Content = new StackLayout
            {
                Children = {
                    header,
                    datePicker,
                    timePicker
                }
            };
        }
	}
}