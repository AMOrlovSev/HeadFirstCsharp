namespace _005_PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите колличество карт, которое нужно выбрать: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Число недействительно");
            }
        }
    }
}
