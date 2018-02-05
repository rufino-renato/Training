﻿using Xamarin.Forms;

namespace People
{
	public partial class App : Application
	{
		public App (string displayText)
		{
			InitializeComponent();

			MainPage = new People.MainPage()
			{
                Text = displayText
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
