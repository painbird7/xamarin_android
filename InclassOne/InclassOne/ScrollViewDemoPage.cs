using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
	public class ScrollViewDemoPage : ContentPage
	{
		public ScrollViewDemoPage()
		{
            Label heading = new Label { Text = "ScrollView", FontSize = 40, FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalTextAlignment = TextAlignment.Center };
            ScrollView scrollView = new ScrollView
            {
                Content = new Label
                {
                    Text = "Elitr et sadipscing nam duo et consetetur consequat ut ipsum dolore dolor tincidunt vero ut elitr velit velit accusam dolore." +
                    "\n\nEt ea et labore takimata nihil accusam duis justo iusto amet odio erat iriure gubergren nonumy et vel eu dolore dolore laoreet est rebum consetetur takimata dolore justo et diam." +
                    "\n\nNerat sanctus qui esse diam nulla est elitr lorem diam ea et ea stet lorem clita et et ipsum ut accusam eirmod lorem possim et nibh vel takimata sea amet ea tempor et nostrud amet consetetur ipsum no dolor tempor nisl." +
                    "\n\nImperdiet tempor elitr sit sit amet elitr gubergren dolore labore amet est stet takimata sit dolor aliquyam sanctus rebum gubergren commodo labore lorem vero clita et est clita no gubergren eu aliquyam sed vero in sit eum eirmod ea kasd est vel voluptua." +
                    "\n\nDolores et dolore clita dolor ut elitr et ipsum tempor sed sanctus duis accusam dolor nonumy at aliquyam rebum ut eos et justo sed diam delenit eu et sed vulputate praesent ut." +
                    "\n\nLuptatum sea lorem vero dolor rebum ipsum autem ea tempor euismod dolor sit duo magna erat erat lorem diam voluptua elitr adipiscing erat veniam dolor diam sanctus et dolor amet magna eos esse consequat." +
                    "\n\nJusto aliquip eos suscipit elitr aliquyam dolor duo luptatum diam hendrerit no diam eirmod wisi ea sit elitr consequat vulputate." +
                    "\n\nImperdiet tempor elitr sit sit amet elitr gubergren dolore labore amet est stet takimata sit dolor aliquyam sanctus rebum gubergren commodo labore lorem vero clita et est clita no gubergren eu aliquyam sed vero in sit eum eirmod ea kasd est vel voluptua." +
                    "\n\nNerat sanctus qui esse diam nulla est elitr lorem diam ea et ea stet lorem clita et et ipsum ut accusam eirmod lorem possim et nibh vel takimata sea amet ea tempor et nostrud amet consetetur ipsum no dolor tempor nisl."
                    ,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    VerticalOptions = LayoutOptions.StartAndExpand
                }
            };
            StackLayout layout1 = new StackLayout();
            StackLayout layout2 = new StackLayout { Padding = new Thickness(20, 20, 20, 20)};
            layout1.Children.Add(heading);
            layout2.Children.Add(scrollView);
            Content = new StackLayout
            {

                Children =
                {
                    layout1,
                    layout2
                }

            };
		}
	}
}