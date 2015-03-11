namespace MobileDevices
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM : Device
    {
        // constants
        private const double PricePerMInute = 0.37;

        //fields
        private int? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();
        
        //constrictors
        public GSM(string setModel, Manufacturers setManifacturer)
            : base(setModel, setManifacturer)
        {
            this.battery = null;
            this.display = null;
            this.owner = null;
            this.price = null;
        }

        public GSM(string setModel, Manufacturers setManifacturer, int? setPrice, string setOwner, Battery setBattery, Display setDisplay)
            : base(setModel, setManifacturer)
        {
            this.battery = setBattery;
            this.display = setDisplay;
            this.owner = setOwner;
            this.Price = setPrice;
        }

        // properties
        public static GSM Iphone4S
        {
            get
            {
                GSM iphone4S = GSM.SetIphone4S();
                return iphone4S;
            }
        }

        public int? Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be a negatic number!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Owner cannot be set az null or empty;");
                }

                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            private set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            private set
            {
                this.display = value;
            }
        }

        /* 
       Use it to set the static Iphone propery as well as a static metod for the GSM class 
       which returns a new GSM instance wit iPhone4S parameters
       (this is outside the homework, jut made it to check how it works)
        */

        // static public methods
        public static GSM SetIphone4S()
        {
            string iPhoneModel = "Iphone4S";
            Battery ibattery = new Battery("bullshit", Manufacturers.APPLE, BatteryTypes.NiCd, 10, 2);
            Display idisplay = new Display("iShit", Manufacturers.SHARP, 256, 3.5M);
            string iOwner = "iDiot";
            int iPrice = int.MaxValue;

            GSM iphone4S = new GSM(iPhoneModel, Manufacturers.APPLE, iPrice, iOwner, ibattery, idisplay);

            return iphone4S;
        }

        // non static methods
        public void AddCall(Call newCall) 
        {
            this.callHistory.Add(newCall);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public void DeliteCall(int callIndex)
        {
            this.callHistory.RemoveAt(callIndex - 1);
        }              

        public string ShowCallHistory()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Call history:");

            if (this.callHistory.Count == 0)
            {
                return "No call history";
            }

            sb.AppendLine("call index - date/time of call - dailed number - call duration ");

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                sb.AppendLine(String.Format("{0} - {1:yyyy/MM/dd - HH:mm} -> {2} call Duration {3} second", 
                                i + 1, 
                                this.callHistory[i].DateOfCall, 
                                this.callHistory[i].DialedPhoneNumber, 
                                this.callHistory[i].CallDurationInSeconds));
            }

            return sb.ToString();
        }

        public double CalculeteTotalPriceOfCalls()
        {
            int totalMinutes = 0;

            foreach (var call in this.callHistory)
            {
                int currCallSeconds = call.CallDurationInSeconds;
                int currCalMinutes = currCallSeconds % 60 == 0 ? (currCallSeconds / 60) : ((currCallSeconds / 60) + 1);
                totalMinutes += currCalMinutes;
            }

            return totalMinutes * PricePerMInute;
        }

        // overrides
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Type - {0}", GetType().Name));
            sb.AppendLine(String.Format("Model - {0}", base.Model));                 
            sb.AppendLine(String.Format("Manifacturer - {0}", base.Manifacturer));

            if (this.battery != null)
            {
                sb.AppendLine(String.Format("{0}:", this.battery.GetType().Name));
                sb.AppendLine(String.Format("Model - {0}", this.battery.Model));
                sb.AppendLine(String.Format("Manifacturer - {0}", this.battery.Manifacturer));

                if (!String.IsNullOrEmpty(this.battery.BatteryType.ToString()))
                {
                    sb.AppendLine(String.Format("Type - {0}", this.battery.BatteryType));
                }

                if (!String.IsNullOrEmpty(this.battery.HoursIdle.ToString()))
                {
                    sb.AppendLine(String.Format("Hours idle - {0}", this.battery.HoursIdle));
                    sb.AppendLine(String.Format("Hours talk - {0}", this.battery.HoursTalk));
                }
            }

            if (this.display != null)
            {
                sb.AppendLine(String.Format("{0}:", this.display.GetType().Name));
                sb.AppendLine(String.Format("Model - {0}", this.display.Model));
                sb.AppendLine(String.Format("Manifacturer - {0}", this.display.Manifacturer));

                if (!String.IsNullOrEmpty(this.display.Size.ToString()))
                {
                    sb.AppendLine(String.Format("Size - {0}", this.display.Size));
                    sb.AppendLine(String.Format("Colors - {0}", this.display.Colors));
                }
            }

            if (!String.IsNullOrEmpty(this.owner))
            {
                sb.AppendLine(String.Format("Owner - {0}", this.owner));
                sb.AppendLine(String.Format("Price - {0}", this.Price));
            }
            
            return sb.ToString().TrimEnd();
        }
    }
}
