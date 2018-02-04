using System.Linq;
using Android.App;
using Android.OS;
using MyTunes.NetStandard;

namespace MyTunes
{
    [Activity(Label = "My Tunes", MainLauncher = true)]
    public class MainActivity : ListActivity
    {
        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //SongLoader.Loader = new StreamLoader(this);
            //var data = await SongLoader.Load();
            var data = await SongLoader.ImprovedLoad();


            ListAdapter = new ListAdapter<Song>()
            {
                DataSource = data.ToList(),
                TextProc = s => s.Name,
                DetailTextProc = s => s.Artist + " - " + s.Album
            };

        }
    }
}


