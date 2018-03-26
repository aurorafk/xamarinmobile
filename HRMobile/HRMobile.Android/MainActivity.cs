using System;
using Xamarin.Forms;
using Microsoft.Identity.Client;
using Android.App;
using Android.Content.PM;
using Android.Content;
using HRMobile;
using Android.OS;

namespace HRMobile.Droid
{
    [Activity(Label = "Wapic HR", Icon = "@drawable/Wapiclogo", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
#pragma warning disable CS0618 // Type or member is obsolete
            App.AuthenticationClient.PlatformParameters = new PlatformParameters(Forms.Context as Activity);
#pragma warning restore CS0618 // Type or member is obsolete
        }
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            AuthenticationAgentContinuationHelper.SetAuthenticationAgentContinuationEventArgs(requestCode, resultCode, data);
        }
    }
}

