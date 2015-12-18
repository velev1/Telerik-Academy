namespace TelerikBest.UI.WUP.ViewModels
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TelerikBest.UI.WUP.Services;

    public class DetailedProjectViewModel : ProjectViewModel
    {
        private string description;
        private string shortDescription;
        private string repositoryUrl;
        private string liveDemoUrl;
        private IEnumerable<string> imageUrls;
        private bool isLiked;
        private bool isFlagged;
        public string Description
        {
            get { return this.description; }
            set
            {
                this.description = value;
                this.OnPropertyChanged("Description");
            }
        }

        public string ShortDescription
        {
            get { return this.shortDescription; }
            set
            {
                this.shortDescription = value;
                this.OnPropertyChanged("ShortDescription");
            }
        }

        public string RepositoryUrl
        {
            get { return this.repositoryUrl; }
            set
            {
                this.repositoryUrl = value;
                this.OnPropertyChanged("RepositoryUrl");
            }
        }

        public string LiveDemoUrl
        {
            get { return this.liveDemoUrl; }
            set
            {
                this.liveDemoUrl = value;
                this.OnPropertyChanged("LiveDemoUrl");
            }
        }

        public IEnumerable<string> ImageUrls
        {
            get { return this.imageUrls; }
            set
            {
                this.imageUrls = value;
                this.OnPropertyChanged("ImageUrls");
            }
        }

        public bool IsLiked
        {
            get { return this.isLiked; }
            set
            {
                this.isLiked = value;
                this.OnPropertyChanged("IsLiked");
            }
        }

        public bool IsFlagged
        {
            get { return this.isFlagged; }
            set
            {
                this.isFlagged = value;
                this.OnPropertyChanged("IsFlagged");
            }
        }
   
        public async Task GetDetails(string url)
        {
            var taBestService = new TaBestService();

            var response = await taBestService.GetDetailedProject(url);

            this.Id = response.Id;
            this.Title = response.Title;
            this.Description = response.Description;
            this.LiveDemoUrl = response.LiveDemoUrl;
            this.RepositoryUrl = response.RepositoryUrl;
            this.MainImageUrl = response.MainImageUrl;
            this.Likes = response.Likes;
            this.Visits = response.Visits;
            this.Comments = response.Comments;

            this.MainImageUrl = this.GetImageHighUrl(response.MainImageUrl);
        }

        private string GetImageHighUrl(string drirctory)
        {
            return string.Format("http://best.telerikacademy.com/images/{0}_high.jpg", drirctory);
        }
    }
}
