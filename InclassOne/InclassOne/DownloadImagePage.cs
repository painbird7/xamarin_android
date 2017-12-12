using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
    public class DownloadImagePage : ContentPage
    {
        public DownloadImagePage()
        {
            string uri = "https://cdn.thenewstack.io/media/2014/05/docker_devops.png";
            Content = new StackLayout
            {
                Children = {
                    new Label {Text = "Download Image", FontSize = 30, FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                        HorizontalOptions = LayoutOptions.Center },
                    new Image { Source = ImageSource.FromUri(new Uri(uri)), VerticalOptions = LayoutOptions.CenterAndExpand }
                }
            };
        }
    }
}
	
