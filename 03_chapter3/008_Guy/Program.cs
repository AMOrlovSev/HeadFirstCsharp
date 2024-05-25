namespace _008_Guy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создайте новый объект Guy в переменной с именем joe
            Guy joe = new Guy();
            // Присвойте его полю Name значение "Joe"
            joe.Name = "Joe";
            // Присвойте его полю Cash значение 50
            joe.Cash = 50;
            // Создайте новый объект Guy в переменной с именем bob
            // Присвойте его полю Name значение "Bob"
            // Присвойте его полю Cash значение 100
            Guy bob = new Guy() {Name = "Bob", Cash = 100 };

            while (true)
            {
                // Вызовите методы WriteMyInfo для каждого объекта Guy
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                // Используйте метод int.TryParse для преобразования строки howMuch в int
                // (как это было сделано ранее в этой главе)
                if (int.TryParse(howMuch, out int money))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        // Вызовите метод GiveCash объекта joe и сохраните результат
                        int cashGiven = joe.GiveCash(money);
                        // Вызовите метод ReceiveCash объекта bob с сохраненным результатом
                        bob.ReceiveCash(cashGiven);
                    }
                    else if (whichGuy == "Bob")
                    {
                        // Вызовите метод GiveCash объекта bob и сохраните результат
                        int cashGiven = bob.GiveCash(money);
                        // Вызовите метод ReceiveCash объекта joe с сохраненным результатом
                        joe.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }
                    else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }
        }
    }

}
