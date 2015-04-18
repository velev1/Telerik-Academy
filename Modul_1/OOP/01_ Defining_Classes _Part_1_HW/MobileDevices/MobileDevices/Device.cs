namespace MobileDevices
{
    using System;
    using System.Text;

    public class Device
    {
        // fields
        private string model;
        private Manufacturers manifacturer;

        // constructors 
        public Device(string initializeModel, Manufacturers setManifacturer)
        {
            this.Model = initializeModel;
            this.manifacturer = setManifacturer; 
        }

        // properties
        public string Model
        {
            get
            {
               return this.model;
            }

            protected set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The model cannot be empty!");
                }

                this.model = value;
            }
        }

        public Manufacturers Manifacturer
        {
            get 
            {
                return this.manifacturer;
            }

            protected set 
            {
                this.manifacturer = value;
            }
        }
    }
}
