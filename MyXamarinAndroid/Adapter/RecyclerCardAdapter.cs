using System;
using System.Collections.Generic;
using Android.Content;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using MyXamarinAndroid.Model;

namespace MyXamarinAndroid.Adapter
{
    public class RecyclerCardAdapter : RecyclerView.Adapter
    {
        private List<Animal> _data;
        private LayoutInflater _inflater;

        public RecyclerCardAdapter(Context context, List<Animal> data)
        {
            _inflater = LayoutInflater.From(context);
            _data = data;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var currentObj = _data[position];
            var viewHolder = holder as MyViewHolder;
            viewHolder.SetData(currentObj, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = _inflater.Inflate(Resource.Layout.recyclercard_list_item, parent, false);
            MyViewHolder holder = new MyViewHolder(view);
            return holder;
        }

        public override int ItemCount => _data.Count;

        class MyViewHolder : RecyclerView.ViewHolder
        {
            private TextView _title;
            private ImageView _imgThumb;
            private Animal _current;
            private int _position;
            public MyViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
            {
            }

            public MyViewHolder(View itemView) : base(itemView)
            {
                _title = itemView.FindViewById<TextView>(Resource.Id.txvv_row);
                _imgThumb = itemView.FindViewById<ImageView>(Resource.Id.imgg_row);
            }

            public void SetData(Animal currentObj, int position)
            {
                _title.Text = currentObj.Title;
                _imgThumb.SetImageResource(currentObj.ImageId);
                _position = position;
                _current = currentObj;
            }
        }
    }
}