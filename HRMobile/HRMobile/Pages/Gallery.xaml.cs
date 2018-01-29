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
	public partial class Gallery : ContentPage
	{
		public Gallery ()
		{
			InitializeComponent ();
            Image1.Source = ImageSource.FromFile("img1.jpg");
		}
	}
}