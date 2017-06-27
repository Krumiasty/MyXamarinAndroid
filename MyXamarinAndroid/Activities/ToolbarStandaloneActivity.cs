using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "ToolbarStandaloneActivity", Theme = "@style/MyCustomTheme")]
    public class ToolbarStandaloneActivity : Activity
    {
        private Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ToolbarStandaloneLayout);

            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.Title = "Welcome";
            toolbar.Subtitle = "Folks !";
            //toolbar.SetLogo(Resource.Drawable.good_day);

            toolbar.InflateMenu(Resource.Menu.toolbar_menu);
            toolbar.MenuItemClick += (sender, args) =>
            {
                var msg = "";
                switch (args.Item.ItemId)
                {
                    case Resource.Id.discard:
                        msg = "Deleted";
                        break;
                    case Resource.Id.search:
                        msg = "Search";
                        break;
                    case Resource.Id.edit:
                        msg = "Edit";
                        break;
                    case Resource.Id.settings:
                        msg = "Settings";
                        break;
                    case Resource.Id.exit:
                        msg = "Exit";
                        break;
                    default:
                        break;
                }

                Toast.MakeText(this, msg + " clicked !", ToastLength.Short).Show();
            };
        }

       
    }
}