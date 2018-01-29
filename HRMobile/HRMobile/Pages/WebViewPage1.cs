using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HRMobile.Pages
{
    class WebViewPage1 : ContentPage
    {
        public WebViewPage1()
        {
            Padding = new Thickness(0, 20, 0, 0);
            Content = new StackLayout
            {
                Children = {
                new MyCustomWebView {
                    Uri = "db.pdf",
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand
                }
            }
            };
        }
    }
}