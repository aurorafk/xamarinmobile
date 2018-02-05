using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HRMobile.Pages;
using FreshMvvm;
using HRMobile.PageModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HRMobile
{
	public partial class MainPage
	{
        private Image[] images = new Image[3];


        public MainPage()
        {
            InitializeComponent();
            //images[0] = img1;
            //images[1] = img1;
            //images[2] = img1;
            //images[3] = img1;
            //images[4] = img1;
            //images[5] = img1;
        }

        private async void button_Clicked_3(object sender, EventArgs e)
        {
            //Run rediect
            await SetPage((Image)sender);

        }

        public async Task SetPage(Image i)
        {
            //Find the filename of the image sending the request
            //ie. User clicked on one of the images

            i.Opacity = 0.4; //blur image to indicate it has been clicked

            var source = i.Source as FileImageSource;

            var filename = source.File;

            string string_name = filename.ToString();


            switch (string_name)
            {
                case "policy1.jpg":

                    //this.HomePage. = true;
                    await Navigation.PushAsync(new Pages.Policy());
                    //Make image visible 
                    i.Opacity = 1;

                    break;
                case "utube1.jpg":

                    //Page myPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<YouTubeChannelPageModel>());
                    await Navigation.PushAsync(FreshPageModelResolver.ResolvePageModel<YouTubeChannelPageModel>());
                    break;
                    
                case "Hrinfo1.jpg":

                    //this.HomePage. = true;
                    await Navigation.PushAsync(new Pages.Policy1());
                    //Make image visible 
                    i.Opacity = 1;

                    break;
               }


        }

    }
}
//        Button[] b = new Button[3];
//		public MainPage()
//		{
//			InitializeComponent();
//            b[0] = button1;
//            b[1] = button2;
//            b[2] = button3;
//        }
//        public async void Button_Clicked(object sender,EventArgs e)
//        {
//            var button = (Button)sender;
//            var classId = button.ClassId;
//            switch (button.ClassId) // I want to get the name of the control 
//            {

//                case "btn1":
//                    var a = new Pages.Stuff();
//                    await Navigation.PushAsync(a);
//                    break;

//                case "btn2":
//                    var b = new Pages.Policy();
//                    await Navigation.PushAsync(b);
//                    break;

//                case "btn3":
//                    Page myPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<YouTubeChannelPageModel>());
//                    await button.Navigation.PushModalAsync(myPage);
//                    break;
//            }

//            }
//    }
//}
