using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "MyXamarinAndroid", MainLauncher = true, Icon = "@drawable/icon", 
        Theme = "@android:style/Theme.Material.Light.NoActionBar")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button newAcitvityButton = FindViewById<Button>(Resource.Id.newActivityButton);
            newAcitvityButton.Click += (sender, args) =>
            {
                var newActivityIntent = new Intent(this, typeof(CustomTextViewActivity));
                StartActivity(newActivityIntent);
            };

            Button lengthPickerButton = FindViewById<Button>(Resource.Id.lengthPickerButton);
            lengthPickerButton.Click += (sender, args) =>
            {
                var lengthPickerIntent = new Intent(this, typeof(LengthPickerActivity));
                StartActivity(lengthPickerIntent);
            };

            Button squareViewButton = FindViewById<Button>(Resource.Id.squareViewButton);
            squareViewButton.Click += (sender, args) =>
            {
                var squareViewIntent = new Intent(this, typeof(SquareViewActivity));
                StartActivity(squareViewIntent);
            };

            Button photoSpiralButton = FindViewById<Button>(Resource.Id.photoSpiralButton);
            photoSpiralButton.Click += (sender, args) =>
            {
                var photoSpiralIntent = new Intent(this, typeof(PhotoSpiralActivity));
                StartActivity(photoSpiralIntent);
            };

            Button pizzaButton = FindViewById<Button>(Resource.Id.pizzaButton);
            pizzaButton.Click += (sender, args) =>
            {
                var pizzaIntent = new Intent(this, typeof(PizzaActivity));
                StartActivity(pizzaIntent);
            };

            Button sidewaysButton = FindViewById<Button>(Resource.Id.sidewaysButton);
            sidewaysButton.Click += (sender, args) =>
            {
                var sidewaysIntent = new Intent(this, typeof(SidewaysActivity));
                StartActivity(sidewaysIntent);
            };

            Button actionBarButton = FindViewById<Button>(Resource.Id.actionBarButton);
            actionBarButton.Click += (sender, args) =>
            {
                var actionBarIntent = new Intent(this, typeof(ActionBarActivity));
                StartActivity(actionBarIntent);
            };

            Button toolbarButton = FindViewById<Button>(Resource.Id.toolbarButton);
            toolbarButton.Click += (sender, args) =>
            {
                var actionBarIntent = new Intent(this, typeof(ToolbarActivity));
                StartActivity(actionBarIntent);
            };

            Button toolbarStandaloneButton = FindViewById<Button>(Resource.Id.standaloneToolbarButton);
            toolbarStandaloneButton.Click += (sender, args) =>
            {
                var toolbarStandaloneIntent = new Intent(this, typeof(ToolbarStandaloneActivity));
                StartActivity(toolbarStandaloneIntent);
            };

            Button recyclerViewButton = FindViewById<Button>(Resource.Id.recyclerViewButton);
            recyclerViewButton.Click += (sender, args) =>
            {
                var recyclerViewIntent = new Intent(this, typeof(RecyclerViewActivity));
                StartActivity(recyclerViewIntent);
            };

            Button recyclerCardViewButton = FindViewById<Button>(Resource.Id.recyclerCardViewButton);
            recyclerCardViewButton.Click += (sender, args) =>
            {
                var recyclerCardViewIntent = new Intent(this, typeof(RecyclerCardViewActivity));
                StartActivity(recyclerCardViewIntent);
            };
        }
    }
}

