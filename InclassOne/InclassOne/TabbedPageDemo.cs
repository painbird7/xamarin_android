using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
    public class TabbedPageDemo : TabbedPage
    {
        public TabbedPageDemo() 
        {
            
            this.Children.Add(new DateTimePickerPage()
                {
                    Title = "DateTime Picker Page"
                }    
            );

            this.Children.Add(new BoxViewDemoPage()
                {
                    Title = "BoxView Demo"
                }
            );

            this.Children.Add(new FrameDemoPage()
                {
                    Title = "Frame Demo"
                }
            );

        }
                
    }
}