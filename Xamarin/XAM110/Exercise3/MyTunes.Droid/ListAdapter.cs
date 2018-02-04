using System;
using Android.Widget;
using System.Collections.Generic;
using Android.Views;
using Android.App;

namespace MyTunes
{
	public class ListAdapter<T> : BaseAdapter<T>
	{
		private IList<T> _dataSource;

		public IList<T> DataSource {

			get => _dataSource;
		    set {
				_dataSource = value;
				this.NotifyDataSetChanged();
			}
		}

		public Func<T,string> TextProc { get; set; }
		public Func<T,string> DetailTextProc { get; set; }

		public override long GetItemId(int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var context = Application.Context;

			var view = convertView;
			if (view == null) {
				view = LayoutInflater.FromContext(context).Inflate(
					(DetailTextProc != null) 
					? Android.Resource.Layout.SimpleListItem2
					: Android.Resource.Layout.SimpleListItem1, null);
			}

			T item = _dataSource[position];
			var text = view.FindViewById<TextView>(Android.Resource.Id.Text1);
			text.Text = TextProc == null ? item.ToString() : TextProc(item);

			if (DetailTextProc != null) {
				var detail = view.FindViewById<TextView>(Android.Resource.Id.Text2);
				detail.Text = DetailTextProc(item);
			}

			return view;
		}

		public override int Count => _dataSource.Count;

	    public override T this[int index] => _dataSource[index];
	}
}

