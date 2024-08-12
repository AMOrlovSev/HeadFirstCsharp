using AmazingExtensions;

namespace _10_StringExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Evil clones are wreking havoc. Help!";
            message.IsDistressCall();
        }
    }
}

namespace AmazingExtensions
{
    public static class ExtendAHuman {
        public static bool IsDistressCall(this string s) {
            if (s.Contains("Help!"))
                return true;
            else
                return false;
        }
    }
}