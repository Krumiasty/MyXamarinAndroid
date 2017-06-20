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
    public class Pizza : View
    {
        private Paint paint;
        private int _slicesNumber;

        public Pizza(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
            Init(null, null);
        }

        public Pizza(Context context) : base(context)
        {
            Init(context, null);
        }

        public Pizza(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Init(context, attrs);
        }

        public Pizza(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            Init(context, attrs);
        }

        public Pizza(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
            Init(context, attrs);
        }

        private void Init(Context context, IAttributeSet attrs)
        {
            var strokeWidth = 2;
            var color = Color.Orange;
            if (attrs != null)
            {
                var array = Context.ObtainStyledAttributes(attrs, Resource.Styleable.Pizza);
                strokeWidth = array.GetDimensionPixelSize(Resource.Styleable.Pizza_stroke_width, strokeWidth);
                color = array.GetColor(Resource.Styleable.Pizza_color, color);
                _slicesNumber = array.GetInt(Resource.Styleable.Pizza_num_slices, _slicesNumber);

            }
            paint = new Paint(PaintFlags.AntiAlias);
            paint.SetStyle(Paint.Style.Stroke);
            paint.StrokeWidth = strokeWidth;
            paint.Color = color;
        }

        protected override void OnDraw(Canvas canvas)
        {
            int width = Width - PaddingLeft - PaddingRight;
            int height = Height - PaddingTop - PaddingBottom;
            int cx = width / 2 + PaddingLeft;
            int cy = height / 2 + PaddingTop;
            float diameter = Math.Min(width, height) - paint.StrokeWidth;
            float radius = diameter / 2;

            canvas.DrawCircle(cx, cy, radius, paint);

            DrawPizzaCuts(canvas, cx, cy, radius);
        }

        private void DrawPizzaCuts(Canvas canvas, float cx, float cy, float radius)
        {
            var degree = 360f / _slicesNumber;
            canvas.Save();
            for (int i = 0; i < _slicesNumber; ++i)
            {
                canvas.Rotate(degree, cx, cy);
                canvas.DrawLine(cx, cy, cx, cy - radius, paint);
            }
            canvas.Restore();
        }
    }
}