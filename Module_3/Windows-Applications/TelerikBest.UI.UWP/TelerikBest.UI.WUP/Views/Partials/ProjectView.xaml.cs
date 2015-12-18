namespace TelerikBest.UI.WUP.Views.Partials
{
    using Windows.UI.Xaml.Controls;
    using TelerikBest.UI.WUP.ViewModels;

    public sealed partial class ProjectView : UserControl
    {
        public ProjectView()
        {
            this.InitializeComponent();
            this.DataContext = new ProjectViewModel();
        }
    }
}
