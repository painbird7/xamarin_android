using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
    public class CarouselPageDemo : CarouselPage
    {
        public CarouselPageDemo()
        {
            
            this.Children.Add(new DateTimePickerPage()

            );

            this.Children.Add(new BoxViewDemoPage()

            );

            this.Children.Add(new FrameDemoPage()

            );

        }

    }
}