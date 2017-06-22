using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace MyXamarinAndroid.CustomControls
{
    public class Sideways : LinearLayout
    {
        public Sideways(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public Sideways(Context context) : base(context)
        {
        }

        public Sideways(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public Sideways(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public Sideways(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            SetMeasuredDimension(MeasuredHeight, MeasuredWidth);
        }

        protected override void DispatchDraw(Canvas canvas)
        {
            canvas.Save();
            canvas.Translate(0, Height);
            canvas.Rotate(-90);
            base.DispatchDraw(canvas);
            canvas.Restore();
        }
    }
}