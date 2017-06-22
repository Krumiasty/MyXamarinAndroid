using Android.App;
using Android.OS;

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