namespace StudentsSystem
{
    using System;

    public class Group
    {
        public int GroupNumber { get; set; }
        public Departments DepartmentName { get; set; }
        
        public Group(int groupNumber, Departments depName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = depName;
        }
    }
}
