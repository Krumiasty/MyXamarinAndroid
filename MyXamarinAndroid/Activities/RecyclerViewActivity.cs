using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Widget;
using MyXamarinAndroid.Adapter;
using MyXamarinAndroid.Model;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "RecyclerViewActivity", Theme = "@style/MyCustomTheme")]
    public class RecyclerViewActivity : Activity
    {
        private Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.RecyclerViewLayout);

            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.Title = "Home Page";

            toolbar.InflateMenu(Resource.Menu.toolbar_menu);

            SetupRecyclerView();
        }

        private void SetupRecyclerView()
        {
            RecyclerView recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            RecyclerAdapter adapter = new RecyclerAdapter(this, Landscape.GetData());
            recyclerView.SetAdapter(adapter);

            LinearLayoutManager linearLayoutManagerVertical = new LinearLayoutManager(this);
            linearLayoutManagerVertical.Orientation = (int)Orientation.Vertical;
            recyclerView.SetLayoutManager(linearLayoutManagerVertical);

            recyclerView.SetItemAnimator(new DefaultItemAnimator());
        }
    }
}