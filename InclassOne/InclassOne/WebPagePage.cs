using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
    public class WebPagePage : ContentPage
    {
        public WebPagePage()
        {
            string uri = "https://www.yahoo.com/news/";
            Content = new StackLayout
            {
                Children = {
                    new Label {Text = "Webpage", FontSize = 30, FontAttributes = FontAttributes.Bold,
                        HorizontalOptions = LayoutOptions.Center },
                    new WebView { Source = uri, VerticalOptions = LayoutOptions.FillAndExpand }
                }
            };
        }
	}
}