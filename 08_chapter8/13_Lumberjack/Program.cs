using System;

namespace _13_Lumberjack
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Queue<Lumberjack> lumberjackQueue = new Queue<Lumberjack>();

            Console.Write("\nFirst lumberjack's name: ");
            string name = Console.ReadLine();

            while (name != "")
            {
                Console.Write("\nNumber of flapjacks: ");
                if (int.TryParse(Console.ReadLine(), out int number) && number!=0)
                {
                    Lumberjack lumberjack = new Lumberjack(name);
                    for (int i = 0; i < number; i++)
                    {
                        lumberjack.TakeFlapjack((Flapjack)rnd.Next(Enum.GetNames(typeof(Flapjack)).Length));
                    }
                    lumberjackQueue.Enqueue(lumberjack);
                }
                Console.Write("\nNext lumberjack's name (blank to end): ");
                name = Console.ReadLine();
            }

            while (lumberjackQueue.Count > 0)
            {
                lumberjackQueue.Dequeue().EatFlapjack();
            }
        }
    }
}
