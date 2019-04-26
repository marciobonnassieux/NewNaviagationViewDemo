using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NaviagationViewDemo
{
   public class ToolbarPage : ContentPage
    {
        public ToolbarItem toolbarItem;
        public static int item;
        public ToolbarPage()
        {
            
            // public ToolbarItem(string name, string icon, Action activated, ToolbarItemOrder order = ToolbarItemOrder.Default, int priority = 0);
             toolbarItem =new ToolbarItem();
            toolbarItem.Icon = "ring2.png";
           
            toolbarItem.Order = ToolbarItemOrder.Primary;
           // toolbarItem.Text = item+"";
            toolbarItem.Priority = 0;
        
            toolbarItem.Clicked += ToolbarItem_Clicked;
            ToolbarItems.Add(toolbarItem);
            if (item >= 1)
            {
                DependencyService.Get<IToolbarItemBadgeService>().SetBadge(this, toolbarItem, $"{item}", Color.Red, Color.White);
            }
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            item = item + 1;
            DependencyService.Get<IToolbarItemBadgeService>().SetBadge(this, toolbarItem, $"{item}", Color.Red, Color.White);
        }

        
    }
   
}
