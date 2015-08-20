namespace VersionAttribute
{
    using System;
    using System.Runtime.InteropServices;

    [Version(1, 0)]
    [Version(1, 1)]
    [Version(1, 2)]
    public class VersionAttributeTestingArea
    {
        public static void Main()
        {
            Type type = typeof(VersionAttributeTestingArea);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in allAttributes)
            {
            Console.WriteLine(
                "This version is {0} ",
                versionAttribute.Full);
            }
        }
    }
}
