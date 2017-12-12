using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
    public class FormsMenuPage : ContentPage
    {
        //private ContactDatabase _database;
        public FormsMenuPage()
        {

            Command<Page> pageCommand =
                new Command<Page>((Page page) =>
                {
                    Navigation.PushAsync(page);
                });

            Title = "Forms Menu";

            Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("Class Project Apps")
                    {
                        new TextCell
                        {
                            Text = "Slider and Switch App",
                            Command = pageCommand,
                            CommandParameter = new SliderAndSwitch(),
                        },

                        new TextCell
                        {
                            Text = "StopWatch App",
                            Command = pageCommand,
                            CommandParameter = new StopWatchAppPage(),
                        },

                        new TextCell
                        {
                            Text = "Contact List",
                            Command = pageCommand,
                            CommandParameter = new ContactListPage(),
                        },
                    },

                    new TableSection("Views for Presentation")
                    {
                        new TextCell
                        {
                            Text = "Label Demo",
                            Command = pageCommand,
                            CommandParameter = new LabelDemoPage(),
                        },

                        new TextCell
                        {
                            Text = "BoxView Demo",
                            Command = pageCommand,
                            CommandParameter = new BoxViewDemoPage(),
                        },

                        new TextCell
                        {
                            Text = "Local Image",
                            Command = pageCommand,
                            CommandParameter = new LocalImagePage(),
                        },

                        new TextCell
                        {
                            Text = "Download Image",
                            Command = pageCommand,
                            CommandParameter = new DownloadImagePage(),
                        },

                        new TextCell
                        {
                            Text = "WebPage",
                            Command = pageCommand,
                            CommandParameter = new WebPagePage(),
                        },
                    },


                    new TableSection("Views that Initiate Commands")
                    {

                    },

                    new TableSection("Views for Command Data Types")
                    {
                        new TextCell
                        {
                            Text = "Date Picker and Time Picker",
                            Command = pageCommand,
                            CommandParameter = new DateTimePickerPage(),
                        },
                    },

                    new TableSection("Views for Editing Text")
                    {

                    },

                    new TableSection("Views to Indicate Activity")
                    {

                    },

                    new TableSection("Views that Display Collections")
                    {

                    },


                    new TableSection("Layouts with Single Content")
                    {
                         new TextCell
                        {
                            Text = "ScrollView",
                            Command = pageCommand,
                            CommandParameter = new ScrollViewDemoPage(),

                        },

                        new TextCell
                        {
                            Text = "Frame Demo",
                            Command = pageCommand,
                            CommandParameter = new FrameDemoPage(),
                        },
                    },

                    new TableSection("Layouts with Multiple Children")
                    {
                        new TextCell
                        {
                            Text = "StackLayout Demo",
                            Command = pageCommand,
                            CommandParameter = new StackLayoutDemoPage(),
                        },
                    },

                    new TableSection("Pages")
                    {

                        new TextCell
                        {
                            Text = "ContentPage",
                            Command = pageCommand,
                            CommandParameter = new ContentPageDemoPage(),
                        },

                        new TextCell
                        {
                            Text = "NavigationPage",
                            Command = pageCommand,
                            CommandParameter = new NavigationPageDemo(),
                        },

                         new TextCell
                        {
                            Text = "Tabbed Page",
                            Command = pageCommand,
                            CommandParameter = new TabbedPageDemo(),
                        },

                         new TextCell
                        {
                            Text = "Carousel Page",
                            Command = pageCommand,
                            CommandParameter = new CarouselPageDemo(),
                        },

                    }
                }
            };
        }
    }
}