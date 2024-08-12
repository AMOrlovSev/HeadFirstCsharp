namespace _07_Null2
{
#nullable enable
    class Program
    {
        static void Main(string[] args)
        {
            using (var stringReader = new StringReader(""))
            {
                var nextLine = stringReader.ReadLine() ?? String.Empty; ;
                Console.WriteLine("Line length is: {0}", nextLine.Length);
            }
        }
    }
}
