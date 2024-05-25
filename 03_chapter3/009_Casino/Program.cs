using _008_Guy;

namespace _009_Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "The player", Cash = 100 };

            Console.WriteLine($"Welcom to the casino. The odds are {odds}");

            while(player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.WriteLine("How much do you want to bet: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = amount * 2;
                    double result = random.NextDouble();
                    if (result > odds) 
                    { 
                        player.ReceiveCash(amount);
                        Console.WriteLine("You win: " + pot);
                    }
                    else
                    {
                        player.GiveCash(amount);
                        Console.WriteLine("You lose: " + amount);
                    }
                }
            }
            Console.WriteLine("The house always wins.");
        }
    }
}
