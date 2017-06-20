using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace MyXamarinAndroid.CustomControls
{
    public class VersionView : TextView
    {
        public VersionView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
            SetVersion();
        }

        public VersionView(Context context) : base(context)
        {
            SetVersion();
        }

        public VersionView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            SetVersion();
        }

        public VersionView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            SetVersion();
        }

        public VersionView(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
            SetVersion();
        }

        private void SetVersion()
        {
            try
            {
                PackageInfo packageInfo = Context.PackageManager.GetPackageInfo(Context.PackageName, 0);
                Text = packageInfo.VersionName;
            }
            catch (PackageManager.NameNotFoundException e)
            {
            }
        }
    }
}