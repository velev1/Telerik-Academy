namespace Cosmetics.Common
{
    public static class ExeptionMassages
    {
        public static string LengthErrorMessage(string name, int min, int max)
        {
            string message = string.Format("{0} must be between {1} and {2} symbols long!", name, min, max);
            return message;
        }
    }
}
