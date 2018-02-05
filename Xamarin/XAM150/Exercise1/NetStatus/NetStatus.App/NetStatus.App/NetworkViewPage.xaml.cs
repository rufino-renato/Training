﻿using System.Linq;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetStatus.App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NetworkViewPage : ContentPage
	{
		public NetworkViewPage ()
		{
			InitializeComponent ();
		}

	    protected override void OnAppearing()
	    {
            base.OnAppearing();

	        if (CrossConnectivity.Current == null)
	            return;

	        ConnectionDetails.Text = CrossConnectivity.Current.ConnectionTypes.First().ToString();

	        CrossConnectivity.Current.ConnectivityChanged += UpdateNetworkInfo;
	    }

	    protected override void OnDisappearing()
	    {
	        base.OnDisappearing();

	        if (CrossConnectivity.Current != null)
	            CrossConnectivity.Current.ConnectivityChanged -= UpdateNetworkInfo;
	    }

	    private void UpdateNetworkInfo(object sender, ConnectivityChangedEventArgs e)
	    {
	        if (CrossConnectivity.Current != null && CrossConnectivity.Current.ConnectionTypes != null)
	        {
	            var connectionType = CrossConnectivity.Current.ConnectionTypes.FirstOrDefault();
	            ConnectionDetails.Text = connectionType.ToString();
	        }
	    }
    }
}