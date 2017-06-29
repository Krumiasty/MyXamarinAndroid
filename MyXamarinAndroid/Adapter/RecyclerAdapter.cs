using System;
using System.Collections.Generic;
using Android.Content;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using MyXamarinAndroid.Model;

namespace MyXamarinAndroid.Adapter
{
    public class RecyclerAdapter : RecyclerView.Adapter
    {
        private List<Landscape> _data;
        private LayoutInflater _inflater;

        public RecyclerAdapter(Context context, List<Landscape> data)
        {
            _data = data;
            _inflater = LayoutInflater.FromContext(context);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            Log.Debug("TAG", $"OnBindViewHolder {position}");

            Landscape currentObj = _data[position];
            var viewHolder = holder as MyViewHolder;
            viewHolder.SetData(currentObj, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            Log.Debug("TAG", "OnCreateViewHolder");
            View view = _inflater.Inflate(Resource.Layout.recycler_list_item, parent, false);
            MyViewHolder holder = new MyViewHolder(view);
            return holder;
        }

        public override int ItemCount => _data.Count;

        class MyViewHolder : RecyclerView.ViewHolder
        {
            private TextView _title;
            private ImageView _imgThumb, _imgDelete, _imgAdd;
            private int _position;
            private Landscape _current;
            public MyViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
            {
            }

            public MyViewHolder(View itemView) : base(itemView)
            {
                _title = itemView.FindViewById<TextView>(Resource.Id.tvTitle);
                _imgThumb = itemView.FindViewById<ImageView>(Resource.Id.img_row);
                _imgDelete = itemView.FindViewById<ImageView>(Resource.Id.img_row_delete);
                _imgAdd = itemView.FindViewById<ImageView>(Resource.Id.img_row_add);
            }

            public void SetData(Landscape currentObj, int position)
            {
                _title.Text = currentObj.Title;
                _imgThumb.SetImageResource(currentObj.ImageId);
                _position = position;
                _current = currentObj;
            }
        }
    }
}