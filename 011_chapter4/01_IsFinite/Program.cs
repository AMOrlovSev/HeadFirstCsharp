namespace _01_IsFinite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (float f = 10; float.IsFinite(f); f *= f)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("");

            for (double d = 10; double.IsFinite(d); d *= d)
            {
                Console.WriteLine(d);
            }
        }
    }
}
