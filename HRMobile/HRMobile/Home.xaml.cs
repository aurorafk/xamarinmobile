using HRMobile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : MasterDetailPage
    {
        public List<MasterPageItem> Menulist{ get; set; }
        public Home()
        {
            string name = "Aurora";
            Menulist = new List<MasterPageItem>();
            InitializeComponent();
            //MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            var page1 = new MasterPageItem() { Title = "Home", Icon = "home", TargetType = typeof(MainPage) };
            var page2 = new MasterPageItem() { Title = "People", Icon = "loading", TargetType = typeof(Pages.Policy1) };
            var page3 = new MasterPageItem() { Title = "Highlights", Icon = "settings", TargetType = typeof(Pages.Stuff) };
            var page4 = new MasterPageItem() { Title = "Policies", Icon = "technology", TargetType = typeof(Pages.Policy) };
            var page5 = new MasterPageItem() { Title = "About", Icon = "trending", TargetType = typeof(HomeDetail) };
            var page6 = new MasterPageItem() { Title = "Gallery", Icon = "loading", TargetType = typeof(Pages.Gallery) };

            Menulist.Add(page1);
            Menulist.Add(page2);
            Menulist.Add(page3);
            Menulist.Add(page4);
            Menulist.Add(page5);
            Menulist.Add(page6);

            navigationDrawerList.ItemsSource = Menulist;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage)));

            this.BindingContext = new
            {
                //Header = "",
                Image = "NiceColourful.jpg",
                Footer = "Welcome " + name
            };

        

            }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;


        }

        private async void OnClick(object sender, EventArgs e)
        {
            var browser = new Pages.Login();
            await Navigation.PushAsync(browser);
        }
        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = e.SelectedItem as HomeMenuItem;
        //    if (item == null)
        //        return;

        //    var page = (Page)Activator.CreateInstance(item.TargetType);
        //    page.Title = item.Title;

        //    Detail = new NavigationPage(page);
        //    IsPresented = false;

        //    MasterPage.ListView.SelectedItem = null;
        //}
    }
}