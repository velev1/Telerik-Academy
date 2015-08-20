namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        // fields
        private decimal weekSalary;
        private decimal workHoursPerDay;

        // constructors
        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {     
        }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : this(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        // properties
        public decimal WeekSalary 
        {
            get
            {
                return this.weekSalary;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Selary can not be negative");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Working hours can not be negative");
                }

                this.workHoursPerDay = value;
            }
        }

        // metjods
        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5); // assume that the working fay are 5 because it is not definited
        }
    }
}
