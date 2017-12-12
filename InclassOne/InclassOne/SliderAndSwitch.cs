using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
	public class SliderAndSwitch : ContentPage
	{
        
        public SliderAndSwitch()
		{
            
            bool bgColor = true;
            Label headingLabel = new Label
            {
                Text = "Frame Demo",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Frame frame = new Frame { WidthRequest = 200, HeightRequest = 200, BackgroundColor = Color.White, HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Content = new Label { Text = "My frame demo!", TextColor = Color.Black, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) }
                };
            
            StackLayout layout = new StackLayout { BackgroundColor = Color.Blue };

            Button button = new Button { Text = "CLICK ME!", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1, HorizontalOptions = LayoutOptions.Center, Margin = new Thickness(20,20,20,20)};
            button.Clicked += OnButtonClicked;
                
            Label switchLabel = new Label { Text = "Switch Colors", HorizontalOptions = LayoutOptions.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, 
                typeof(Label)), TextColor = Color.White };
            Switch mySwitch = new Switch { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness (0,10,0,0) };
            mySwitch.Toggled += mySwitch_Toggled;
            Label sliderLabel = new Label { Text = "Frame Dimension: 200", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.End, TextColor = Color.White };
            Slider slider = new Slider { Maximum = 300, Minimum = 10, Value = 200, Margin = new Thickness(20,20,20,20), VerticalOptions = LayoutOptions.End };
            slider.ValueChanged += sliderChanged;
            
            layout.Children.Add(headingLabel);
            layout.Children.Add(frame);
            layout.Children.Add(button);
            layout.Children.Add(switchLabel);
            layout.Children.Add(mySwitch);
            layout.Children.Add(sliderLabel);
            layout.Children.Add(slider);

            
            Content = layout;

            void OnButtonClicked(object sender, EventArgs args)
            {
                bgColor = !bgColor;
                if(bgColor)
                {
                    layout.BackgroundColor = Color.Blue;
                    
                }
                else
                {
                    layout.BackgroundColor = Color.Green;
                }
            };

            void mySwitch_Toggled(object sender, ToggledEventArgs args)
            {
                if (args.Value)
                {
                    frame.BackgroundColor = Color.Gray;
                    ((Label)frame.Content).TextColor = Color.White;
                }
                else
                {
                    frame.BackgroundColor = Color.White;
                    ((Label)frame.Content).TextColor = Color.Black;
                }
            }

            void sliderChanged(object sender, ValueChangedEventArgs args)
            {
                int newValue = Convert.ToInt32(slider.Value);
                frame.HeightRequest = newValue;
                frame.WidthRequest = newValue;
                sliderLabel.Text = "Frame Dimension: " + newValue.ToString();
            }
        }
	}
}