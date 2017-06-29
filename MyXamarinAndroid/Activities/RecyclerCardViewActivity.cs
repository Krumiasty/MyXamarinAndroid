using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using MyXamarinAndroid.Adapter;
using MyXamarinAndroid.Model;

namespace MyXamarinAndroid.Activities
{
    [Activity(Label = "RecyclerCardViewActivity", Theme = "@style/MyCustomTheme")]
    public class RecyclerCardViewActivity : Activity
    {
        private Toolbar toolbar;
        private RecyclerView recyclerView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.RecyclerCardViewLayout);

            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.Title = "Home Page";
            toolbar.InflateMenu(Resource.Menu.recyclercard_menu);
            toolbar.MenuItemClick += Toolbar_MenuItemClick;
            SetupRecyclerView();
        }

        private void Toolbar_MenuItemClick(object sender, Toolbar.MenuItemClickEventArgs e)
        {
            switch (e.Item.ItemId)
            {
                case Resource.Id.linearViewHorizontal:
                    var linearLayoutManagerHorizontal = new LinearLayoutManager(this);
                    linearLayoutManagerHorizontal.Orientation = (int)Orientation.Horizontal;
                    recyclerView.SetLayoutManager(linearLayoutManagerHorizontal);
                    break;

                case Resource.Id.linearViewVertical:
                    var linearLayoutManagerVertical = new LinearLayoutManager(this);
                    linearLayoutManagerVertical.Orientation = (int)Orientation.Vertical;
                    recyclerView.SetLayoutManager(linearLayoutManagerVertical);
                    break;

                case Resource.Id.gridView:
                    var gridLayoutManager = new GridLayoutManager(this, 2);
                    recyclerView.SetLayoutManager(gridLayoutManager);
                    break;

                case Resource.Id.staggeredViewHorizontal:
                    var staggeredHorizontalLayoutManager = new StaggeredGridLayoutManager(2, (int)Orientation.Horizontal);
                    recyclerView.SetLayoutManager(staggeredHorizontalLayoutManager);
                    break;

                case Resource.Id.staggeredViewVertical:
                    var staggeredVerticalLayoutManager = new StaggeredGridLayoutManager(2, (int)Orientation.Vertical);
                    recyclerView.SetLayoutManager(staggeredVerticalLayoutManager);
                    break;
            }
        }

        private void SetupRecyclerView()
        {
            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerCardView);
            RecyclerCardAdapter adapter = new RecyclerCardAdapter(this, Animal.GetData());
            recyclerView.SetAdapter(adapter);

            LinearLayoutManager linearLayoutManagerVertical = new LinearLayoutManager(this);
            linearLayoutManagerVertical.Orientation = (int)Orientation.Vertical;
            recyclerView.SetLayoutManager(linearLayoutManagerVertical);

            recyclerView.SetItemAnimator(new DefaultItemAnimator());
        }
    }
}