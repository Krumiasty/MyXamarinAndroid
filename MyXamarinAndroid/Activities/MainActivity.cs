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

            Button squareViewButton = FindViewById<Button>(Resource.Id.squareViewButton);
            squareViewButton.Click += (sender, args) =>
            {
                var squareViewIntent = new Intent(this, typeof(SquareViewActivity));
                StartActivity(squareViewIntent);
            };

            Button photoSpiralButton = FindViewById<Button>(Resource.Id.photoSpiralButton);
            photoSpiralButton.Click += (sender, args) =>
            {
                var photoSpiralIntent = new Intent(this, typeof(PhotoSpiralActivity));
                StartActivity(photoSpiralIntent);
            };

            Button pizzaButton = FindViewById<Button>(Resource.Id.pizzaButton);
            pizzaButton.Click += (sender, args) =>
            {
                var pizzaIntent = new Intent(this, typeof(PizzaActivity));
                StartActivity(pizzaIntent);
            };
        }
    }
}

