using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Identity.Client;
using Xamarin.Forms;

namespace HRMobile
{
	public partial class App : Application
	{
        public static PublicClientApplication AuthenticationClient { get; set; }

        // Step #1: Add Azure AD B2C tenant information.
        public static string ClientId = "b2bf126a-1f9c-46be-b350-2e7c89070037";
        public static string SignUpSignInPolicy = "B2C_1_WapicInsiderPolicy";
        public static string ProfileEdit = "B2C_1_WiPe";
        public static string PasswordReset = "B2C_1_WiPr";
        public static string Authority = "https://login.microsoftonline.com/WapicInsurancePlc.onmicrosoft.com/";
        public static string[] Scopes = { ClientId };

        public App()
        {
            InitializeComponent();

            AuthenticationClient = new PublicClientApplication(ClientId);

            MainPage = new NavigationPage(new Pages.Login());
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
