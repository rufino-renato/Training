using Xamarin.Forms;

namespace People
{
	public partial class App : Application
	{
	    public static PersonRepository PersonRepo { get; private set; }

        public App (string filename)
		{
			InitializeComponent();

		    PersonRepo = new PersonRepository(filename);

		    this.MainPage = new MainPage();
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
