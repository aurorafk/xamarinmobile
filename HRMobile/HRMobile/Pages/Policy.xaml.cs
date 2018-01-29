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
	public partial class Policy : ContentPage
	{
        private Button[] buttons =new Button[9];
        public Policy ()
		{
            InitializeComponent();
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;
            buttons[0] = button1;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var classId = button.ClassId;
            switch (button.ClassId) // I want to get the name of the control 
            {

                case "btn1":
                    var a = new WebViewPage();
                    await Navigation.PushAsync(a);
                    break;

                case "btn2":
                    var b = new Pages.MyWebViewPage1();
                    await Navigation.PushAsync(b);
                    break;

                case "btn3":
                    var c = new Pages.MyWebViewPage2();
                    await Navigation.PushAsync(c);
                    break;
                case "btn4":
                    var d = new Pages.MyWebViewPage3();
                    await Navigation.PushAsync(d);
                    break;
                case "btn5":
                    var ee = new Pages.MyWebViewPage4();
                    await Navigation.PushAsync(ee);
                    break;
                case "btn6":
                    var f = new Pages.MyWebViewPage5();
                    await Navigation.PushAsync(f);
                    break;
                case "btn7":
                    var g = new Pages.MyWebViewPage6();
                    await Navigation.PushAsync(g);
                    break;
                case "btn8":
                    var h = new Pages.MyWebViewPage7();
                    await Navigation.PushAsync(h);
                    break;
                case "btn9":
                    var i = new Pages.MyWebViewPage8();
                    await Navigation.PushAsync(i);
                    break;
                case "btn10":
                    var j = new Pages.MyWebViewPage9();
                    await Navigation.PushAsync(j);
                    break;
            }


        }

    }
}