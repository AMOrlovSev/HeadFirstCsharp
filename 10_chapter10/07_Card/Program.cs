using System.Linq;

namespace _06_CardLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filename = "deckofcards.txt";
            Deck deck = new Deck();
            deck.Shuffle();
            for (int i = deck.Count - 1; i > 10; i--)
                deck.RemoveAt(i);
            deck.WriteCards(filename);
            Deck cardsToRead = new Deck(filename);
            foreach (var card in cardsToRead)
                Console.WriteLine(card.Name);
        }

        private static IOrderedEnumerable<IGrouping<Suits, Card>> SelectSuitGroup(IEnumerable<Card> deck)
        {
            return from card in deck
                   group card by card.Suit into suitGroup
                   orderby suitGroup.Key descending
                   select suitGroup;
        }
    }
}
