namespace MobileDevices
{
    using System;    

    public class Battery : Device
    {
        // fields
        private int hoursIdle;
        private int hoursTalk;
        private BatteryTypes batteryType;

        // constructors
        public Battery(string setModel, Manufacturers setManifacturer)
            : base(setModel, setManifacturer)
        {
        }

        public Battery(string setModel, Manufacturers setManifacturer, BatteryTypes setBatteryType)
            : this(setModel, setManifacturer)
        {
            this.batteryType = setBatteryType;
        }

        public Battery(string setModel, Manufacturers setManifacturer,  BatteryTypes setBatteryType, int setHoursIdle, int setHoursTalk)
            : this(setModel, setManifacturer, setBatteryType)            
        {
            this.HoursIdle = setHoursIdle;
            this.HoursTalk = setHoursTalk;
        }
        
        // properties
        public BatteryTypes BatteryType
        {
            get 
            {
                return this.batteryType;
            }

            private set
            {
                this.batteryType = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Batery idle hours cannot be  negative!");
                }

                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Batery talk hours cannot be  negative!");
                }

                this.hoursTalk = value;
            }
        }
    }
}
