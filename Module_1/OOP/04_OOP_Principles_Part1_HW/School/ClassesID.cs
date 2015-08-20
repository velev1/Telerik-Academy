namespace School
{
    using System;
    using System.Collections.Generic;

    public class ClassesID
    {
        // field - Hashset to keep the all used class IDs
        private static HashSet<string> classesIDs = new HashSet<string>();

        public static HashSet<string> ClassesIDs
        {
            get
            {
                return classesIDs;
            }
        }

        public static bool CheckID(string newID)
        {
            // if the class ID is allready in use this method returns ture, else returns false and adds the new ID in the set of used ones
            if (classesIDs.Contains(newID))
            {
                return true;
            }
            else
            {
                classesIDs.Add(newID);
                return false;
            }
        }
    }
}
