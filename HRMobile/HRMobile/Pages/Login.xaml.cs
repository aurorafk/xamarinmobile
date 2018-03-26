using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRMobile.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}
        private async void LoginClick(Object sender, EventArgs e)
        {

            try
            {
                // Step #2: Authenticate with Microsoft Authentication Library (MSAL).
                // Authenticate users with Microsoft Authentication Library (MSAL).
                var authenticationResult = await App.AuthenticationClient.AcquireTokenAsync(App.Scopes,
                    "",
                    UiOptions.SelectAccount,
                    string.Empty,
                    null,
                    App.Authority,
                    App.SignUpSignInPolicy
                    );
                // Navigate users into the main portion of our app.
                Application.Current.MainPage = new Home();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error Authenticating", ex.Message, "OK");
            }
            //var username_field = username.Text;
            //var password_field = password.Text;

            ////Make username and password WAPIC

            //if ((username_field.ToLower() == "a") && (password_field.ToLower() == "a"))
            //{
            //    //await Navigation.PushAsync(new Home());

            //    //Set the main page to our master detail Page
            //    Application.Current.MainPage = new Home();

            //}
            //else if ((username_field.ToLower() == "a") && (password_field.ToLower() == null))
            //{
            //    await DisplayAlert("Error", "Sa code or Password is incorrect?", "Retry", "Cancel");
            //}
            //else if ((username_field.ToLower() == null) && (password_field.ToLower() == "a"))
            //{
            //    await DisplayAlert("Error", "Sa code or Password is incorrect?", "Retry", "Cancel");
            //}
            //else if ((username_field.ToLower() == null) && (password_field.ToLower() == null))
            //{
            //    await DisplayAlert("Error", "Sa code or Password is incorrect?", "Retry", "Cancel");
            //}
            //else
            //{
            //    await DisplayAlert("Error", "Sa code or Password is incorrect?", "Retry", "Cancel");
            //}
        }
    }
}