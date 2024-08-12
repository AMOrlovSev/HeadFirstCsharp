namespace _05_Named_OptionalArguments
{
    internal class Program
    {
        static void CheckTemperature(double temp, double tooHigh = 99.5, double tooLow = 96.5)
        {
            if (temp < tooHigh && temp > tooLow)
                Console.WriteLine("{0} degrees F - feeling good!", temp);
            else
                Console.WriteLine("Uh-oh {0} degrees F -- better see a doctor!", temp);
        }

        static void Main(string[] args)
        {
            CheckTemperature(101.3);
            // Температура собаки от 100.5 до 102.5 по Фаренгейту
            CheckTemperature(101.3, 102.5, 100.5);
            // Температура Боба всегда ниже обычной, задаем tooLow значение 95.5
            CheckTemperature(96.2, tooLow: 95.5);
        }
    }
}
