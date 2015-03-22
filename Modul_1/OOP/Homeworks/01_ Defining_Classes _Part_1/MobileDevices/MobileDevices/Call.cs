namespace MobileDevices
{
    using System;

    public class Call
    {
        // fields
        private int callDurationInSeconds;
        private string dialedPhoneNumber;
        private DateTime dateAndTimeOfCall;

        // constructors
        public Call(DateTime inicializeDateAndTime, string numberDialed, int addCallDuration)
        {
            this.DateOfCall = inicializeDateAndTime;
            this.DialedPhoneNumber = numberDialed;
            this.CallDurationInSeconds = addCallDuration;
        }

        // properties
        public DateTime DateOfCall
        {
            get
            {
                return this.dateAndTimeOfCall;
            }

            private set
            {
                this.dateAndTimeOfCall = value;
            }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }

            private set
            {
                /*
                StyleCope make jokes with me - when I uoe String.IsNullOrEmpty(value) it says wrong, 
                dont use this, whe I try value == null || value == String.Empty it says - wrong - don't use  String.Empty, 
                then I tried value == null || value == "", again wrong - it says value == String.Empty instead "". 
                If you know the right answer please share :)
                */

                if (value == null || value == String.Empty || value.Length < 8)
                {
                    throw new FormatException("Phone number invalid format!");
                }

                this.dialedPhoneNumber = value;
            }
        }

        public int CallDurationInSeconds
        {
            get
            {
                return this.callDurationInSeconds;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Call duration cannot be negative!");
                }

                this.callDurationInSeconds = value;
            }
        }
    }
}
