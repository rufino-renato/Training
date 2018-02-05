using Xamarin.Forms;

namespace People
{
	public partial class MainPage : ContentPage
	{

	    public string Text
	    {
	        get => textLabel.Text;
	        set => textLabel.Text = value;
	    }

		public MainPage()
		{
			InitializeComponent();
		}
	}
}
