using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using Xamarin.Forms;

namespace InclassOne
{
	public class StopWatchAppPage : ContentPage
	{
        public bool one = false;
        public bool two = false;
        public bool three = false;
        public Stopwatch stopwatch = new Stopwatch();
        public TimeSpan timeSpan = new TimeSpan();

        public StopWatchAppPage()
        {
            Label header = new Label
            {
                Text = "StopWatch App",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand
            };
            Label timerText = new Label
            {
                Text = "00:00:00.00",
                TextColor = Color.Black,
                FontSize = 55,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };
            
            StackLayout buttonLayout = new StackLayout { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.StartAndExpand, Orientation = StackOrientation.Horizontal };
            Button startButton = new Button { Text = "START", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)), BorderWidth = 1, BorderRadius = 252, BackgroundColor = Color.Accent, TextColor = Color.Black };
            startButton.Clicked += startButtonClicked;

            Button stopButton = new Button { Text = "STOP", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)), BorderWidth = 1, BorderRadius = 22, BackgroundColor = Color.Accent, TextColor = Color.Black };
            stopButton.Clicked += stopButtonClicked;

            Button resetButton = new Button { Text = "RESET", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)), BorderWidth = 1, BorderRadius = 22, BackgroundColor = Color.Accent, TextColor = Color.Black };
            resetButton.Clicked += startButtonClicked;

            buttonLayout.Children.Add(startButton);
            buttonLayout.Children.Add(stopButton);
            buttonLayout.Children.Add(resetButton);

            Frame frame = new Frame
            {
                BackgroundColor = Color.FromRgb(200,200,200),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                Margin = new Thickness(0, 30, 0, 30),
                Content = new StackLayout
                {
                    Children = {
                        timerText,
                    buttonLayout
                    }
                }
            };
               
            Content = new StackLayout {
                Children = {
                    header,
                    frame
                    }
                
			};
            
            void start(bool one)
            {
                if (one == false)
                {
                    stopwatch.Start();
                    Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>
                    {
                        timeSpan = stopwatch.Elapsed;
                        timerText.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
                        return one;
                    });
                    one = true;
                }
            }

            void stop(bool one)
            {
                if (one == true)
                {
                    stopwatch.Stop();
                    one = false;
                    timerText.Text = timerText.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);

                }
            }

            void startButtonClicked(object sender, EventArgs e)
            {
                start(one);
            }

            void stopButtonClicked(object sender, EventArgs e)
            {
                stop(one);
            }
        }
	}
}