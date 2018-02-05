﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace People.Droid
{
    [Activity(Label = "People", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            string dbPath = FileAccessHelper.GetLocalFilePath("people.db3");
            LoadApplication(new App(dbPath));
        }
    }
}

