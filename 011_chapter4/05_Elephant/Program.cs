namespace _05_Elephant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant Lloyd = new Elephant()
            {
                Name = "Lloyd",
                EarSize = 40
            };

            Elephant Lucinda = new Elephant()
            {
                Name = "Lucinda,",
                EarSize = 30
            };

            //Lloyd.HearMessage("Hi", Lucinda);

            //Lucinda.SpeakTo(Lloyd, "Hi, Lloyd!");

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while (true) 
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + input);
                if (input == '1' )
                {
                    Lloyd.WhoAmI();
                }
                else if (input == '2')
                {
                    Lucinda.WhoAmI();
                }
                else if(input == '3')
                {
                    Elephant temp = Lloyd;
                    Lloyd = Lucinda;
                    Lucinda = temp;
                    Console.WriteLine("References have been swapped");
                }
                else if (input == '4')
                {
                    Lloyd = Lucinda;
                    Lloyd.EarSize = 4321;
                    Lloyd.WhoAmI();
                }
                else if (input == '5')
                {
                    Lucinda.SpeakTo(Lloyd, "Hi, Lloyd!");
                }
                else return;
                Console.WriteLine();
            }
            

        }
    }
    public class Elephant
    {
        public string Name { get; set; }
        public int EarSize { get; set; }
        public void WhoAmI()
        {
            Console.WriteLine($"Calling {Name}.WhoAmI()");
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"My ears are { EarSize} inches tall.");
        }
        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
