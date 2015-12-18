namespace TelerikBest.UI.WUP.ViewModels
{
    using System;
    using System.Collections.Generic;
    using TelerikBest.UI.WUP.Models;

    public class ProjectViewModel : BaseViewModel
    {
        private int id;
        private string title;
        private string mainImageUrl;
        private DateTime createdOn;
        private string shortDate;
        private int likes;
        private int visits;
        private int comments;
        private int flags;
        private bool isHidden;
        private string url;
        public int Id
        {
            get { return this.id; }
            set
            {
                this.id = value;
                this.OnPropertyChanged("Id");
            }
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                this.title = value;
                this.OnPropertyChanged("Title");
            }
        }

        public string Url
        {
            get { return this.GetUrl(); }
            set
            {
                this.url = this.GetUrl();
                this.OnPropertyChanged("Url");
            }
        }

        public string MainImageUrl
        {
            get { return this.mainImageUrl; }
            set
            {
                this.mainImageUrl = value;
                this.OnPropertyChanged("MainImageUrl");
            }
        }

        public DateTime CreatedOn
        {
            get { return this.createdOn; }
            set
            {
                this.createdOn = value;
                this.OnPropertyChanged("CreatedOn");
            }
        }

        public string ShortDate
        {
            get { return this.shortDate; }
            set
            {
                this.shortDate = value;
                this.OnPropertyChanged("ShortDate");
            }
        }

        public int Likes
        {
            get { return this.likes; }
            set
            {
                this.likes = value;
                this.OnPropertyChanged("Likes");
            }
        }

        public int Visits
        {
            get { return this.visits; }
            set
            {
                this.visits = value;
                this.OnPropertyChanged("Visits");
            }
        }

        public int Comments
        {
            get { return this.comments; }
            set
            {
                this.comments = value;
                this.OnPropertyChanged("Comments");
            }
        }

        public int Flags
        {
            get { return this.flags; }
            set
            {
                this.flags = value;
                this.OnPropertyChanged("Flags");
            }
        }

        public bool IsHidden
        {
            get { return this.isHidden; }
            set
            {
                this.isHidden = value;
                this.OnPropertyChanged("IsHidden");
            }
        }

        private string GetUrl()
        {
            var title = this.title.Replace(' ', '-');
            var result = this.Id + "/" + title;

            return result;
        }

        public IEnumerable<ColaboratorViewModel> Collaborators { get; set; }

        public IEnumerable<TagViewModel> Tags { get; set; }
    }
}
