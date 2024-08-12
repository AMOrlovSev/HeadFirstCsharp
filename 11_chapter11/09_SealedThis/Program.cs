namespace _09_SealedThis
{
    sealed class OrdinaryHuman
    {
        private int age;
        int weight;
        public OrdinaryHuman(int weight)
        {
            this.weight = weight;
        }
        public void GoToWork() { /* Код для выхода на работу */ }
        public void PayBills() { /* Код для оплаты счетов */ }
    }

    static class AmazeballsSerum
    {
        public static string BreakWalls(this OrdinaryHuman h, double wallDensity)
        {
            return ($"I broke through a wall of {wallDensity} density.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            OrdinaryHuman steve = new OrdinaryHuman(185);
            Console.WriteLine(steve.BreakWalls(89.2));
        }
    }
}
