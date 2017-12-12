using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
	public class LabelDemoPage : ContentPage
	{
		public LabelDemoPage ()
		{
            Content = new StackLayout {
                Children = {
                    new Label { Text = "Label Demo Page",
                        FontSize = 40, FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                        HorizontalTextAlignment = TextAlignment.Center },
                    new Label { Text = "Xamarin.Forms is a cross-platform natively backed UI toolkit abstraction that allows developers to easily create user " +
                        "interfaces that can be shared across Android, iOS, and Windows Phone.",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                    
                }
			};
		}
	}
}