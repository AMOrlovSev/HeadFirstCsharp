namespace _03_AbilityScoreTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = AbilityScoreCalculator.ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = AbilityScoreCalculator.ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = AbilityScoreCalculator.ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = AbilityScoreCalculator.ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }

            //AbilityScoreCalculator calculator1 = new AbilityScoreCalculator();
            //AbilityScoreCalculator calculator2 = calculator1;

            //calculator1.RollResult = 3;
            //Console.WriteLine(calculator1.RollResult);
            //Console.WriteLine(calculator2.RollResult);
        }
    }
    public class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;
        public void CalculateAbilityScore()
        {
            // Результат броска делится на значение поля DivideBy
            double divided = RollResult / DivideBy;
            // AddAmount прибавляется к результату деления
            int added = AddAmount + (int)divided;
            // Если результат слишком мал, использовать значение Minimum
            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }
        /// <summary>
        /// Выводит сообщение и читает значение int с консоли.
        /// </summary>
        /// <param name="lastUsedValue">Значение по умолчанию.</param>
        /// <param name="prompt">Сообщение, выводимое на консоль.</param>
        /// <returns>Прочитанное значение int или значение по умолчанию, если преобразование
        /// невозможно.</returns>
        static public int ReadInt(int lastUsedValue, string prompt)
        {
            // Вывести сообщение, за которым следует [значение по умолчанию]:
            Console.Write($"{prompt} [{lastUsedValue}]:");
            // Прочитать строку из ввода и попытаться преобразовать ее вызовом int.TryParse
            if (int.TryParse(Console.ReadLine(), out int resultTemp))
            // Если преобразование прошло успешно, вывести на консоль строку " using value" + value.
            {
                Console.WriteLine($" using value {resultTemp}");
                return resultTemp;
            }
            // В противном случае вывести на консоль строку " using default value" + lastUsedValue
            else
            {
                Console.WriteLine($" using default value {lastUsedValue}");
                return lastUsedValue;
            }
        }
        static public double ReadDouble(double lastUsedValue, string prompt)
        {
            // Вывести сообщение, за которым следует [значение по умолчанию]:
            Console.Write($"{prompt} [{lastUsedValue}]:");
            // Прочитать строку из ввода и попытаться преобразовать ее вызовом double.TryParse
            if (double.TryParse(Console.ReadLine(), out double resultTemp))
            // Если преобразование прошло успешно, вывести на консоль строку " using value" + value.
            {
                Console.WriteLine($" using value {resultTemp}");
                return resultTemp;
            }
            // В противном случае вывести на консоль строку " using default value" + lastUsedValue
            else
            {
                Console.WriteLine($" using default value {lastUsedValue}");
                return lastUsedValue;
            }
        }
    }
}
