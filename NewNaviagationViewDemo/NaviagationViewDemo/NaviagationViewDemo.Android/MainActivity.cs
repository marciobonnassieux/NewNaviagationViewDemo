using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace NaviagationViewDemo.Droid
{
    [Activity(Label = "NaviagationViewDemo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        public override bool OnPrepareOptionsMenu(IMenu menu)
        {
            

          //  BadgeDrawable.SetBadgeCount(this, menu.GetItem(1), 3, Color.Red, Color.White);
            return base.OnPrepareOptionsMenu(menu);
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
         //   BadgeDrawable.SetBadgeCount(this, menu.GetItem(0), 3, Color.Red, Color.White);
            return base.OnCreateOptionsMenu(menu);
        }
        
    }
}