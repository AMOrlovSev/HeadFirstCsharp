namespace _02_Bird
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Bird bird;
                Console.Write("\nPress P for pigeon, O for ostrich: ");
                char key = Char.ToUpper(Console.ReadKey().KeyChar);
                if (key == 'P') bird = new Pigeon();
                else if (key == 'O') bird = new Ostrich();
                else return;
                Console.Write("\nHow many eggs should it lay? ");
                if (!int.TryParse(Console.ReadLine(), out int numberOfEggs)) return;
                Egg[] eggs = bird.LayEggs(numberOfEggs);
                foreach (Egg egg in eggs)
                {
                    Console.WriteLine(egg.Description);
                }
            }
        }
    }
    class Egg
    {
        public double Size { get; private set; }
        public string Color { get; private set; }
        public Egg(double size, string color)
        {
            Size = size;
            Color = color;
        }
        public string Description
        {
            get { return $"A {Size:0.0}cm {Color} egg"; }
        }
    }
    class BrokenEgg : Egg
    {
        public BrokenEgg(string color) : base(0, $"broken {color}")
        {
            Console.WriteLine("A bird laid a broken egg");
        }
    }
    class Bird
    {
        public static Random Randomizer = new Random();
        public virtual Egg[] LayEggs(int numberOfEggs)
        {
            Console.Error.WriteLine("Bird.LayEggs should never get called");
            return new Egg[0];
        }
    }
    class Pigeon:Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                string color = "white";
                double size = Randomizer.Next(1, 3) + Randomizer.Next(0, 10) / 10.0;
                if (Bird.Randomizer.Next(4) == 0)
                {
                    eggs[i] = new BrokenEgg("white");
                }
                else
                    eggs[i] = new Egg(size, color);
            }
            return eggs;
        }
    }
    class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                int minSize = 12;
                string color = "speckled";
                double size = minSize + Randomizer.Next(0, 10) / 10.0;
                eggs[i] = new Egg(size, color);
            }
            return eggs;
        }
    }
}
