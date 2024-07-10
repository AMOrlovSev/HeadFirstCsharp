using System.Security.Cryptography;

namespace _04_magnits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] badgers = { 36, 5, 91, 3, 41, 69, 8 };

            var bears =
                from pigeon in badgers
                where (pigeon != 36 && pigeon < 50)
                orderby pigeon descending
                select pigeon + 5;

            var skunks =
                from sparrow in bears
                select sparrow - 1;

            var weasels = skunks.Take(3);

            Console.WriteLine("Get your kicks on route {0}", weasels.Sum());
        }
    }
}
