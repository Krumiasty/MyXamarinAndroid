using Android.App;
using Android.OS;
using Android.Widget;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "TransitionActivity", Theme = "@style/MyCustomTheme")]
    public class TransitionActivity : Activity
    {
        private TextView _animationName;
        private Button _exitButton;
        private Toolbar _toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TransitionLayout);

            _animationName = FindViewById<TextView>(Resource.Id.animationName);
            _exitButton = FindViewById<Button>(Resource.Id.exitButton);
            _toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            _exitButton.Click += (sender, args) =>
            {
                FinishAfterTransition();
            };

            var type = Intent.GetStringExtra("Title");
            _animationName.Text = type;

            _toolbar.Title = "Animations";
        }
    }
}