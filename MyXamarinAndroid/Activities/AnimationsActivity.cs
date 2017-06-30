using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "AnimationsActivity", Theme = "@style/MyCustomTheme")]
    public class AnimationsActivity : Activity
    {
        private TextView _txvRippleWithBorder;
        private TextView _txvRippleWithoutBorder;
        private TextView _txvCustomRippleWithBorder;
        private TextView _txvCustomRippleWithoutBorder;

        private Button _explodeCodeButton;
        private Button _explodeXmlButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AnimationsLayout);

            BindControl();

            _txvRippleWithBorder.Click += (sender, args) =>
            {

            };

            _txvRippleWithoutBorder.Click += (sender, args) =>
            {

            };

            _explodeCodeButton.Click += (sender, args) =>
            {
                ActivityOptions options = ActivityOptions.MakeSceneTransitionAnimation(this);
                Intent acitvityIntent = new Intent(this, typeof(TransitionActivity));
                acitvityIntent.PutExtra("Type", "ExplodeCode");
                acitvityIntent.PutExtra("Title", "Explode Animation");
                acitvityIntent.PutExtra("Name", "Explode by Code");
                StartActivity(acitvityIntent, options.ToBundle());
            };

            _explodeXmlButton.Click += (sender, args) =>
            {

            };
        }

        private void BindControl()
        {
            _txvRippleWithBorder = FindViewById<TextView>(Resource.Id.txvRippleWithBorder);
            _txvRippleWithoutBorder = FindViewById<TextView>(Resource.Id.txvRippleWithoutBorder); 
            _txvCustomRippleWithBorder = FindViewById<TextView>(Resource.Id.txvCustomRippleWithBorder); 
            _txvCustomRippleWithoutBorder = FindViewById<TextView>(Resource.Id.txvCustomRippleWithoutBorder);

            _explodeCodeButton = FindViewById<Button>(Resource.Id.explodeJava);
            _explodeXmlButton = FindViewById<Button>(Resource.Id.explodeXML);
        }
    }
}