using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
	public class NavigationPageDemo : ContentPage
	{
		public NavigationPageDemo()
		{
            StackLayout layout1 = new StackLayout();
            StackLayout layout2 = new StackLayout { Orientation = StackOrientation.Horizontal, HorizontalOptions = LayoutOptions.Center };
            Label headingLabel = new Label
            {
                Text = "NavigationPage",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalTextAlignment = TextAlignment.Center
            };
            Button labelPageButton = new Button { Text = "Label Demo Page", FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button)), BorderWidth = 1 };
            labelPageButton.Clicked += OnButtonClicked;

            Button scrollViewPageButton = new Button { Text = "ScrollView Demo Page", FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button)), BorderWidth = 1};
            scrollViewPageButton.Clicked += OnButtonClicked;

            Button stackLayoutPageButton = new Button { Text = "StackLayout Demo Page", FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button)), BorderWidth = 1};
            stackLayoutPageButton.Clicked += OnButtonClicked;

            layout1.Children.Add(headingLabel);
            layout2.Children.Add(labelPageButton);
            layout2.Children.Add(scrollViewPageButton);
            layout2.Children.Add(stackLayoutPageButton);
            

            Content = new StackLayout
            {
                
                Children =
                {
                    layout1,
                    layout2
                }

            };


            void OnButtonClicked(object sender, EventArgs args)
            {
                
                var myValue = ((Button)sender).Text;
                if (myValue == "Label Demo Page")
                {
                    Navigation.PushAsync(new LabelDemoPage());
                }
                else if(myValue == "ScrollView Demo Page")
                {
                    Navigation.PushAsync(new ScrollViewDemoPage());
                }
                else if (myValue == "StackLayout Demo Page")
                {
                    Navigation.PushAsync(new StackLayoutDemoPage());
                }
            };
        }
    }
}