using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var username_field = username.Text;
            var password_field = password.Text;

            //Make username and password WAPIC

            if ((username_field.ToLower() == "a") && (password_field.ToLower() == "a"))
            {
                //await Navigation.PushAsync(new Home());

                //Set the main page to our master detail Page
                Application.Current.MainPage = new Home();

            }
            else if ((username_field.ToLower() == "a") && (password_field.ToLower() == null))
            {
                await DisplayAlert("Error", "Sa code or Password is incorrect?", "Retry", "Cancel");
            }
            else if ((username_field.ToLower() == null) && (password_field.ToLower() == "a"))
            {
                await DisplayAlert("Error", "Sa code or Password is incorrect?", "Retry", "Cancel");
            }
            else if ((username_field.ToLower() == null) && (password_field.ToLower() == null))
            {
                await DisplayAlert("Error", "Sa code or Password is incorrect?", "Retry", "Cancel");
            }
            else
            {
                await DisplayAlert("Error", "Sa code or Password is incorrect?", "Retry", "Cancel");
            }
        }
    }
}