namespace TelerikBest.UI.WUP.Views
{
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Navigation;
    using TelerikBest.UI.WUP.ViewModels;

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProjectDetailedView : Page
    {
        public ProjectDetailedView()
        {
            this.InitializeComponent();
            this.DataContext = new DetailedProjectViewModel();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            var param = e.Parameter as ProjectViewModel;
            var dc = this.DataContext as DetailedProjectViewModel;

            await dc.GetDetails(param.Url);

            base.OnNavigatedTo(e);
        }
    }
}
