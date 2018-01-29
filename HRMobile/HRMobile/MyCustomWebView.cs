﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HRMobile
{
    public class MyCustomWebView: WebView
    {
        public static readonly BindableProperty UriProperty = BindableProperty.Create(propertyName: "Uri",
            returnType: typeof(string),
            declaringType: typeof(MyCustomWebView),
            defaultValue: default(string));
         
        public string Uri
        {
            get { return (string)GetValue(UriProperty); }
            set { SetValue(UriProperty, value); }
        }
    }
}
