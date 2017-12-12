using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
	public class FrameDemoPage : ContentPage
	{
		public FrameDemoPage ()
		{
            Content = new StackLayout {
                Children = {
                    new Label { Text = "Frame Demo",
                        FontSize = 40, FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                        HorizontalTextAlignment = TextAlignment.Center },
                    new Frame { BackgroundColor = Color.Yellow, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.CenterAndExpand,
                        Content = new Label { Text = "This is my Frame Demo!", TextColor = Color.White, BackgroundColor = Color.Teal, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                        }
                    }
                }
			};
            
		}
	}
}