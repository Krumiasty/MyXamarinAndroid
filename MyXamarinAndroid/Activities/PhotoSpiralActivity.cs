﻿using System;
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
    [Activity(Label = "PhotoSpiralActivity", Theme = "@android:style/Theme.Material.Light")]
    public class PhotoSpiralActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PhotoSpiralLayout);
        }
    }
}