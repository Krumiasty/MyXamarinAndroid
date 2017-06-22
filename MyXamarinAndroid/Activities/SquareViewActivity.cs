﻿using Android.App;
using Android.OS;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "SquareViewActivity", Theme = "@android:style/Theme.Material.Light")]
    public class SquareViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SquareView);
        }
    }
}