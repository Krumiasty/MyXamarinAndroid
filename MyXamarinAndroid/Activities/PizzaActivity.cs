using Android.App;
using Android.OS;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "Pizza", Theme = "@android:style/Theme.Material.Light")]
    public class PizzaActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PizzaLayout);
        }
    }
}