using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HRMobile.ViewModels;

namespace HRMobile.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Policy1 : ContentPage
	{
		public Policy1 ()
		{
			InitializeComponent ();
            //BindingContext = new Policy1viewModel();
            

        }
       

    }
}