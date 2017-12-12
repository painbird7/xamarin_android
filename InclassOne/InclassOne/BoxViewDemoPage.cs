using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
	public class BoxViewDemoPage : ContentPage
	{
		public BoxViewDemoPage()
		{
            Content = new StackLayout {
                Children = {
                    new Label { Text = "BoxView Demo Page",
                        FontSize = 40, FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                        HorizontalTextAlignment = TextAlignment.Center
                    },
                    new BoxView { Color = Color.Accent,
                        WidthRequest = 150, HeightRequest = 150,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
			};
		}
	}
}