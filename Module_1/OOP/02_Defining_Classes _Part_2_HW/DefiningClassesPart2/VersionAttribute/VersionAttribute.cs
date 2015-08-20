namespace VersionAttribute
{
    using System;
    using System.Runtime.InteropServices;

    [AttributeUsage(AttributeTargets.Struct |
      AttributeTargets.Class | AttributeTargets.Interface |
      AttributeTargets.Enum | AttributeTargets.Method,
      AllowMultiple = true)]
    public class VersionAttribute : System.Attribute
    {
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
            this.Full = this.Major + "." + this.Minor;
        }

        public int Major { get; private set; }
        public int Minor { get; private set; }
        public string Full { get; private set; }
    }
}
