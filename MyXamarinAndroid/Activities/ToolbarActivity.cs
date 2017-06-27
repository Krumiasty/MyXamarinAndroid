using Android.App;
using Android.OS;
using Android.Transitions;
using Android.Views;
using Android.Widget;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "ToolbarActivity", Theme = "@style/MyCustomTheme")]
    public class ToolbarActivity : Activity
    {
        private Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ToolbarLayout);

            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);

            toolbar.Title = "Welcome !";
            toolbar.Subtitle = "Folks !";

           // toolbar.SetLogo(Resource.Drawable.good_day);
          //  toolbar.SetNavigationIcon(Resource.Drawable.navigation_back);

            //SetupWindowAnimations();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.toolbar_menu, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            var msg = "";
            switch (item.ItemId)
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
            }

            Toast.MakeText(this, msg + " clicked !", ToastLength.Short).Show();

            return base.OnOptionsItemSelected(item);
        }
    }
}