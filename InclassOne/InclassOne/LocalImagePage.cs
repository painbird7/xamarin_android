using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
    public class LocalImagePage : ContentPage
    {
        public LocalImagePage()
        {
            string uri = "chefImage.png";
            Content = new StackLayout
            {
                Children = {
                    new Label {Text = "Local Image", FontSize = 30, FontAttributes = FontAttributes.Bold,
                        HorizontalOptions = LayoutOptions.Center },
                    new Image { Source = ImageSource.FromFile(uri), VerticalOptions = LayoutOptions.CenterAndExpand }
                }
            };
        }
	}
}