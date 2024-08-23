namespace NoteTakingApp.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(NoteDetailsPage), typeof(NoteDetailsPage));
        }
    }
}
