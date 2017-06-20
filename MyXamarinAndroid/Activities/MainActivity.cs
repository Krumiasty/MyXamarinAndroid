using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "MyXamarinAndroid", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Material.Light.NoActionBar")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button newAcitvityButton = FindViewById<Button>(Resource.Id.newActivityButton);
            newAcitvityButton.Click += (sender, args) =>
            {
                var newActivityIntent = new Intent(this, typeof(CustomTextViewActivity));
                StartActivity(newActivityIntent);
            };

            Button lengthPickerButton = FindViewById<Button>(Resource.Id.lengthPickerButton);
            lengthPickerButton.Click += (sender, args) =>
            {
                var lengthPickerIntent = new Intent(this, typeof(LengthPickerActivity));
                StartActivity(lengthPickerIntent);
            };
        }
    }
}

