namespace TelerikBest.UI.WUP.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using TelerikBest.UI.WUP.Commands;
    using TelerikBest.UI.WUP.Common.Extensions;
    using TelerikBest.UI.WUP.Services;

    public class ListPopilarProjectsViewModel : BaseViewModel
    {
        private TaBestService taBestService;
        private ObservableCollection<ProjectViewModel> projects; 

        private ICommand getSunSetRiseInfoCommand;

        public ListPopilarProjectsViewModel()
        {
            this.taBestService = new TaBestService();
            this.HandleGetPopularProjects();
        }

        public ICommand GetSunSetRiseInfo
        {
            get
            {
                if (this.getSunSetRiseInfoCommand == null)
                {
                    this.getSunSetRiseInfoCommand = new RelayCommand(this.HandleGetPopularProjects);
                }

                return this.getSunSetRiseInfoCommand;
            }
        }

        private async void HandleGetPopularProjects()
        {
            var response = await this.taBestService.GetPopularProjects();

            response.Projects.ForEach(p =>
            {
                this.projects.Add(new ProjectViewModel()
                {
                    Title = p.Title,
                    Comments = p.Comments,
                    Likes = p.Likes,
                    Visits = p.Visits,
                    MainImageUrl = this.GetImageHighUrl(p.MainImageUrl),
                    CreatedOn = p.CreatedOn,
                    Id = p.Id
                });
            });
        }

        public IEnumerable<ProjectViewModel> Projects
        {
            get { return this.projects ?? (this.projects = new ObservableCollection<ProjectViewModel>()); }
            set
            {
                if (this.projects == null)
                {
                    this.projects = new ObservableCollection<ProjectViewModel>();
                }

                this.projects.Clear();

                value.ForEach(this.projects.Add);
            }
        }

        private string GetImageHighUrl(string drirctory)
        {
            return string.Format("http://best.telerikacademy.com/images/{0}_high.jpg", drirctory);
        }
    }
}
