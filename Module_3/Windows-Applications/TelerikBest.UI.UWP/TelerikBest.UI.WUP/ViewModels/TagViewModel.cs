namespace TelerikBest.UI.WUP.ViewModels
{
    public class TagViewModel : BaseViewModel
    {
        private int id;
        private string name;
        private int type;
        private string foregroundColor;
        private string backgroundColor;

        public int Id
        {
            get { return this.id; }
            set
            {
                this.id = value;
                this.OnPropertyChanged("Id");
            }
        }


        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                this.OnPropertyChanged("Name");
            }
        }

        public int Type
        {
            get { return this.type; }
            set
            {
                this.type = value;
                this.OnPropertyChanged("Type");
            }
        }

        public string ForegroundColor
        {
            get { return this.foregroundColor; }
            set
            {
                this.foregroundColor = value;
                this.OnPropertyChanged("ForegroundColor");
            }
        }

        public string BackgroundColor
        {
            get { return this.backgroundColor; }
            set
            {
                this.backgroundColor = value;
                this.OnPropertyChanged("BackgroundColor");
            }
        }
    }
}
