namespace _11_Magnets
{
    using Upside;
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string s = i.ToPrice();
            s.SendIt();
            bool b = true;
            b.Green().SendIt();
            b = false;
            i = 3;
            i.ToPrice().SendIt();
        }
    }
}

namespace Upside
{
    public static class Margin
    {
        public static void SendIt(this string s)
        {
            Console.Write(s);
        }
        public static string ToPrice(this int n)
        {
            if (n == 1)
                return "a buck ";
            else
                return " more bucks";
        }
        public static string Green(this bool b)
        {
            if (b == true)
                return "be";
            else
                return "gets";
        }
    }
}
