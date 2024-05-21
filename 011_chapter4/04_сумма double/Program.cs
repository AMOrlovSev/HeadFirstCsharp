namespace _04_сумма_double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (0.1M + 0.2M == 0.3M) Console.WriteLine("They're equal");
            else Console.WriteLine("They aren't equal");

            if (0.1 + 0.2 == 0.3) Console.WriteLine("They're equal");
            else Console.WriteLine("They aren't equal");
        }
    }
}
