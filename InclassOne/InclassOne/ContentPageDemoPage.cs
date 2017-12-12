using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
    public class ContentPageDemoPage : ContentPage
    {
        public ContentPageDemoPage()
        {
            // first label
            var firstLabel = new Label { HorizontalOptions = LayoutOptions.Center };
            var f = new FormattedString();
            f.Spans.Add(new Span { Text = "ContentPage", FontSize = 40, FontAttributes = FontAttributes.Bold });
            firstLabel.FormattedText = f;

            // second label
            var layout = new StackLayout();
            var secondLabel = new Label();
            var s = new FormattedString();
            s.Spans.Add(new Span { Text = "ContentPage is the simplest type of page.", FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) });
            s.Spans.Add(new Span { Text = "\nThe content of a ContentPage is generally a layout of some sort that can then be a parent to multiple children.", FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)) });
            s.Spans.Add(new Span { Text = "\nThis ContentPage contains a StackLayout, which in turn contains four Label views (including the large one at the top.", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) });
            secondLabel.FormattedText = s;

            layout.Children.Add(firstLabel);
            layout.Children.Add(secondLabel);
            Content = layout;
        }
	}
}