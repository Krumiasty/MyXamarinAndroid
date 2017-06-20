using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using MyXamarinAndroid.Annotations;

namespace MyXamarinAndroid.CustomControls
{
    public class LengthPicker : LinearLayout, INotifyPropertyChanged
    {
        private View _plusButton;
        private TextView _inchesView;
        private View _minusButton;

        private int _inchesNumber;
        private static string KEY_SUPER_STATE = "superState";
        private static string KEY_INCHES_NUMBER = "_inchesNumber";

        public LengthPicker(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
            Init();
        }

        public LengthPicker(Context context) : base(context)
        {
            Init();
        }

        public LengthPicker(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Init();
        }

        protected override IParcelable OnSaveInstanceState()
        {
            Bundle bundle = new Bundle();
            bundle.PutParcelable(KEY_SUPER_STATE, base.OnSaveInstanceState());
            bundle.PutInt(KEY_INCHES_NUMBER, _inchesNumber);
            return bundle;
        }

        protected override void OnRestoreInstanceState(IParcelable state)
        {
            var stateBundle = state as Bundle;
            if (stateBundle != null)
            {
                Bundle bundle = (Bundle) state;
                _inchesNumber = bundle.GetInt(KEY_INCHES_NUMBER);
                base.OnRestoreInstanceState((IParcelable)bundle.GetParcelable(KEY_SUPER_STATE));
            }
            else
            {
                base.OnRestoreInstanceState(state);
            }
            UpdateControls();
        }

        private void Init()
        {
            LayoutInflater inflater = LayoutInflater.From(Context);
            inflater.Inflate(Resource.Layout.LengthPicker, this);

            this.Orientation = Orientation.Horizontal;

            _plusButton = FindViewById<Button>(Resource.Id.plusButton);
            _inchesView = FindViewById<TextView>(Resource.Id.inchesView);
            _minusButton = FindViewById<Button>(Resource.Id.minusButton);

            _inchesView.SetTextColor(Color.Black);

            UpdateControls();

            _plusButton.Click += (sender, args) =>
            {
                GetInchesNumber++;
                UpdateControls();
            };

            _minusButton.Click += (sender, args) =>
            {
                GetInchesNumber--;
                UpdateControls();
            };
        }

        private void UpdateControls()
        {
            int feet = _inchesNumber / 12;
            int inches = _inchesNumber % 12;

            string text = string.Format("{0}' {1}\"", feet, inches);
            if (feet == 0)
            {
                text = string.Format($"{inches}\"");
            }
            else
            {
                text = string.Format($"{feet}' {inches}\"");
            }

            _inchesView.Text = text;
            _minusButton.Enabled = _inchesNumber > 0;
        }

        public int GetInchesNumber
        {
            get { return _inchesNumber; }
            set
            {
                _inchesNumber = value;
                OnPropertyChanged(nameof(GetInchesNumber));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}