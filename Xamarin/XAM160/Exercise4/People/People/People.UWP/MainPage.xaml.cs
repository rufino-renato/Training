namespace People.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            string dbPath = FileAccessHelper.GetLocalFilePath("people.db3");

            LoadApplication(new People.App(dbPath));
        }
    }
}
