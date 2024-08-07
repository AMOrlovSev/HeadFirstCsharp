namespace _01_StreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var writer = new StreamWriter("toaster oven.txt", true);
            writer.WriteLine("The {appliance} is set to {temp} degrees.");
            writer.Close();
        }
    }
}
