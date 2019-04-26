using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NaviagationViewDemo
{
    public partial class MainPage : ToolbarPage
    {
        public MainPage()
        {
            InitializeComponent();
            bt1.Text = ToolbarPage.item.ToString();
            bt1.Clicked += async (o, e) =>
            {

               await Navigation.PushAsync(new HelloToolbarInher());
            };
        }
        protected override async void OnAppearing()
        {
            //You must make a delay,
            await  Task.Delay(100);
            bt1.Text = ToolbarPage.item.ToString();
            DependencyService.Get<IToolbarItemBadgeService>().SetBadge(this, toolbarItem, $"{ToolbarPage.item}", Color.Red, Color.White);
        }
     }
}
