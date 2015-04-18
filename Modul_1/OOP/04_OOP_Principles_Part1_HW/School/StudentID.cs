namespace School
{
    using System;
    using System.Collections.Generic;

    public static class StudentID 
    {
        // starts the students IDs from 100
        private static int currentID = 100;

        private static List<int> usedIds = new List<int>();

        public static List<int> UsedIds 
        { 
            get 
            {
                return usedIds; 
            }
        }

        // generates the next ID automatically when this method is used but I dnont know how to restrict
        // it's usage to be possible only when student is initiated with student constructor
        // because if it is used now matter how the next ID is generated anyway :)
        // I'll not refuse ideas how to restrict it's usage 
        public static int NextID()
        {
            currentID++;
            usedIds.Add(currentID);
            return currentID;
        }
    }
}
