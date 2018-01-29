using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HRMobile
{
    class MyWebViewPage : ContentPage
    {
        public MyWebViewPage()
        {
            Padding = new Thickness(0, 20, 0, 0);
            Content = new StackLayout
            {
                Children = {
                new MyCustomWebView {
                    Uri = "FAQ.pdf",
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand
                }
            }
            };
        }
    }
}