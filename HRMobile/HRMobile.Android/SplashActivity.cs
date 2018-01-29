using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HRMobile.Droid
{
    [Activity(Theme = "@style/Theme.Splash",
       //Label = "WAPIC Agent",
       MainLauncher = true,
       NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            //navigates to the main activity
            StartActivity(typeof(MainActivity));
        }
    }
}