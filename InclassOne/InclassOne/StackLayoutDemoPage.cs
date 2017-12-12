using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
	public class StackLayoutDemoPage : ContentPage
	{
        public StackLayoutDemoPage()
        {
            var layout1 = new StackLayout {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Spacing = 0
            };
            

            var label1 = new Label
            {
                Text = "StackLayout",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            var label2 = new Label { Text = "StackLayout", HorizontalOptions = LayoutOptions.Start };
            var label3 = new Label { Text = "stacks its children", HorizontalOptions = LayoutOptions.Center };
            var label4 = new Label { Text = "vertically", HorizontalOptions = LayoutOptions.End };
            var label5 = new Label { Text = "by default", HorizontalOptions = LayoutOptions.Center };
            var label6 = new Label { Text = "but horizontal placement", HorizontalOptions = LayoutOptions.Start };
            var label7 = new Label { Text = "can be controlled with", HorizontalOptions = LayoutOptions.Center };
            var label8 = new Label { Text = "the HorizontalOptions property", HorizontalOptions = LayoutOptions.End };
            var label9 = new Label
            {
                Text = "An Expand option allows one or more children to occupy the area within the remaining space of the StackLayout " +
                    "after it's been sized to the height of its parent",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            layout1.Children.Add(label1);
            layout1.Children.Add(label2);
            layout1.Children.Add(label3);
            layout1.Children.Add(label4);
            layout1.Children.Add(label5);
            layout1.Children.Add(label6);
            layout1.Children.Add(label7);
            layout1.Children.Add(label8);
            layout1.Children.Add(label9);

            var layout2 = new StackLayout {
                Orientation = StackOrientation.Horizontal,
                Spacing = 0
            };
            var label10 = new Label { Text = "Stacking" };
            var label11 = new Label { Text = "can also be", HorizontalOptions = LayoutOptions.CenterAndExpand };
            var label12 = new Label { Text = "horizontal." };
            layout2.Children.Add(label10);
            layout2.Children.Add(label11);
            layout2.Children.Add(label12);


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