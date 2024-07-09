using System.Collections.Generic;

namespace _05_CardComparer
{
    internal class Program
    {
        private static readonly Random random = new Random();
        static Card RandomCard()
        {
            Card card = new Card((Suit)random.Next(4), (Value)random.Next(1, 14));
            return card;
        }
        static void PrintCards(List<Card> cards) 
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                List<Card> cards = new List<Card>();
                Console.Write("\nEnter number of cards: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    for (int i = 0;i< number; i++)
                    {
                        cards.Add(RandomCard());
                    }
                    PrintCards(cards);

                    Console.WriteLine("\n... sorting the cards ...");

                    CardComparerByValue comparer = new CardComparerByValue();
                    cards.Sort(comparer);

                    PrintCards(cards);
                }
                else
                {
                    Console.WriteLine($"\"Not a number");
                }
            }
        }
    }
}
