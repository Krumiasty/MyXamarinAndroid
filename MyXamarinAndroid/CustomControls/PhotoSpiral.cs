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
    public class PhotoSpiral : ViewGroup
    {
        public PhotoSpiral(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public PhotoSpiral(Context context) : base(context)
        {
        }

        public PhotoSpiral(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public PhotoSpiral(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public PhotoSpiral(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            MeasureChildren(widthMeasureSpec, heightMeasureSpec);
            if (ChildCount == 0)
            {
                base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
                return;
            }
            View first = GetChildAt(0);
            int size = first.MeasuredWidth + first.MeasuredHeight;
            int width = ViewGroup.ResolveSize(size, widthMeasureSpec);
            int height = ViewGroup.ResolveSize(size, heightMeasureSpec);
            SetMeasuredDimension(width, height);
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            if (ChildCount == 0)
            {
                return;
            }
            View first = GetChildAt(0);
            int childWidth = first.MeasuredWidth;
            int childHeight = first.MeasuredHeight;

            for (int i = 0; i < ChildCount; ++i)
            {
                View child = GetChildAt(i);
                int x = 0;
                int y = 0;
                switch (i)
                {
                    case 1:
                        x = childWidth;
                        y = 0;
                        break;
                    case 2:
                        x = childHeight;
                        y = childWidth;
                        break;
                    case 3:
                        x = 0;
                        y = childHeight;
                        break;
                }
                child.Layout(x, y, x + child.MeasuredWidth, y + child.MeasuredHeight);
            }
        }
    }
}