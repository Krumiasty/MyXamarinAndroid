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
using MyXamarinAndroid.CustomControls;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "LengthPickerActivity", Theme = "@android:style/Theme.Material.Light")]
    public class LengthPickerActivity : Activity
    {
        private LengthPicker _width;
        private LengthPicker _height;
        private TextView _areaCalculated;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LengthPickerLayout);

            _width = FindViewById<LengthPicker>(Resource.Id.width);
            _height = FindViewById<LengthPicker>(Resource.Id.height);
            _areaCalculated = FindViewById<TextView>(Resource.Id.area_calculated);

            _width.PropertyChanged += (sender, args) =>
            {
                UpdateArea();
            };

            _height.PropertyChanged += (sender, args) =>
            {
                UpdateArea();
            };
        }

        private void UpdateArea()
        {
            int area = _width.GetInchesNumber * _height.GetInchesNumber;
            _areaCalculated.Text = area.ToString();
        }

        protected override void OnResume()
        {
            UpdateArea();
            base.OnResume();
        }
    }
}