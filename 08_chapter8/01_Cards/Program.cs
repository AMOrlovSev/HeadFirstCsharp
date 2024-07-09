namespace _01_Cards
{
    internal class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            Card card = new Card((Suit)random.Next(4), (Value)random.Next(1,14));
            Console.WriteLine(card.Name);
        }
    }
}