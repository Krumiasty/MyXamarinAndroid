using Android.App;
using Android.OS;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "TextView with Version", Theme = "@android:style/Theme.Material.Light")]
    public class CustomTextViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.VersionViewLayout);
        }
    }
}