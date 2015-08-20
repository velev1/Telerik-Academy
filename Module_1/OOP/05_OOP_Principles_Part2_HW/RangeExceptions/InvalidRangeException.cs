namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
        where T : IComparable
    {
        // fields that exeption keeps
        private T starts;
        private T ends;

        // overridig the base constructor [ public ApplicationException(string message, Exception innerException); ] 
        // and initialise this instance of exeption its fields through properties
        public InvalidRangeException(string msg, T starts, T ends, Exception ex)
            : base(FormatMsg(msg, starts, ends), ex) // use FormatMsg for formating thw massage and combine all parameters to one string
        {
            this.Starts = starts;
            this.Ends = ends;
        }

        // constructor without Exeption [ public ApplicationException(string message); ]
        public InvalidRangeException(string msg, T starts, T ends)
            : this(msg, starts, ends, null)
        { 
        }

        // empty constructor [ public ApplicationException(); ]
        // just keep fields
        public InvalidRangeException(T starts, T ends)
            : this(null, starts, ends, null)
        {
        }
          
        // properties
        public T Starts
        {
            get
            {
                return this.starts;
            }

            set
            {
                this.starts = value;
            }
        }

        public T Ends
        {
            get
            {
                return this.ends;
            }

            set
            {
                this.ends = value;
            }
        }

        // private method for formatin themassage
        private static string FormatMsg(string msg, T start, T end)
        {
            string errorMsg = string.Format("{0}, Allowed range: [{1} - {2}] !", msg, start, end);
            return errorMsg;
        }
    }
}
