namespace TelerikBest.UI.WUP.ViewModels
{
    public class ColaboratorViewModel : BaseViewModel
    {
        private string userName;
        private string avatarUrl;

        public string UserName
        {
            get { return this.userName; }
            set
            {
                this.userName = value;
                this.OnPropertyChanged("UserName");
            }
        }

        public string AvatarUrl
        {
            get { return this.avatarUrl; }
            set
            {
                this.avatarUrl = value;
                this.OnPropertyChanged("AvatarUrl");
            }
        }
    }
}
