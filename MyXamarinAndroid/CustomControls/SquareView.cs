using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace MyXamarinAndroid.CustomControls
{
    public class SquareView : View
    {
        public SquareView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public SquareView(Context context) : base(context)
        {
        }

        public SquareView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public SquareView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public SquareView(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);

            int size = Math.Min(MeasuredWidth, MeasuredHeight);
            SetMeasuredDimension(size, size);
        }
    }
}