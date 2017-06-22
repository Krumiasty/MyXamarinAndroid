using Android.App;
using Android.OS;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "Sideways", Theme = "@android:style/Theme.Material.Light")]
    public class SidewaysActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SidewaysLayout);
        }
    }
}