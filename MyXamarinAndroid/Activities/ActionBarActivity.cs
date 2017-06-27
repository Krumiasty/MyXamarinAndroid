using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "ActionBarActivity", UiOptions = UiOptions.SplitActionBarWhenNarrow,
        Theme="@style/Theme.Holo.ActionBarOverlay")] //, Theme = "@android:style/Theme.Holo.Light"
    public class ActionBarActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ActionBarLayout);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.main_menu, menu);

            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menuOption1:
                    OnOption1Clicked(item);
                    break;
                case Resource.Id.menuOption2:
                    OnOption2Clicked(item);
                    break;
                case Resource.Id.menuOption3:
                    OnOption3Clicked(item);
                    break;
                case Resource.Id.menuExit:
                    OnExitClicked(item);
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }

        public override bool OnTouchEvent(MotionEvent e)
        {
            if (e.Action == MotionEventActions.Down)
            {
                ToggleActionBar();
            }

            return true;
        }

        private void ToggleActionBar()
        {
            if (ActionBar != null)
            {
                if (ActionBar.IsShowing)
                {
                    ActionBar.Hide();
                }
                else
                {
                    ActionBar.Show();
                }
            }
        }

        public void SetActionBarLogo()
        {
            ActionBar.SetLogo(Resource.Drawable.pluralsight_logo_whiteback);
        }

        public void SetActionBarTitleAndSubtitle()
        {
            ActionBar.Title = "Android ActionBar";
            ActionBar.Subtitle = "Improve UI Interaction";
            ActionBar.SetDisplayShowTitleEnabled(true);
        }

        public void HideActionBarTitleAndSubtitle()
        {
            ActionBar.SetDisplayShowTitleEnabled(false);
        }

        public void OnOption1Clicked(IMenuItem menuItem)
        {
            SetActionBarLogo();
            ShowToast("Option 1");
        }
        public void OnOption2Clicked(IMenuItem menuItem)
        {
            SetActionBarTitleAndSubtitle();
            ShowToast("Option 2");
        }

        public void OnOption3Clicked(IMenuItem menuItem)
        {
            HideActionBarTitleAndSubtitle();
            ShowToast("Option 3");
        }

        public void OnExitClicked(IMenuItem menuItem)
        {
            Finish();
        }

        private void ShowToast(string message)
        {
            var toast = Toast.MakeText(this, message, ToastLength.Short);
            toast.Show();
        }
    }
}