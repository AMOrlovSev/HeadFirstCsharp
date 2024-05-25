


namespace _001_MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperatorExamples();
            TryAnIf();
            TryAnIfElse();
            TrySomeLoops();
            Loops();
        }

        private static void Loops()
        {
            int count = 5;
            int counter = 0;
            while (count > 0)
            {
                count = count * 3;
                count = count * (-1);
                counter++;
            }
            Console.WriteLine(counter);

            int j = 2;
            int counter1 = 0;
            int counter2 = 0;
            for (int i = 1; i < 100; i = i * 2)
            {
                j = j - 1;
                while (j < 25)
                {
                    j = j + 5;
                    counter2++;
                }
                counter1++;
            }
            Console.WriteLine(counter1 + ", " + counter2);

            int p = 2;
            int counter3 = 0;
            int counter4 = 0;
            for (int q = 2; q < 32; q = q * 2)
            {
                while(p<q)
                {
                    p = p * 2;
                    counter4++;
                }
                q = p - q;
                counter3++;
            }
            Console.WriteLine(counter3 + ", " + counter4);
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "Bobbo Jr.";
            if ((someValue == 3) && (name == "Joe"))
            {
                Console.WriteLine("x is 3 and the name is Joe");
            }
            Console.WriteLine("this line runs no matter what");
        }

        private static void TryAnIfElse()
        {
            int x = 5;
            if (x == 10)
            {
                Console.WriteLine("x must be 10");
            }
            else
            {
                Console.WriteLine("x isn’t 10");
            }
        }

        private static void TrySomeLoops()
        {
            int count = 0;
            while (count < 10)
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            Console.WriteLine("The answer is " + count);
        }

        private static void OperatorExamples()
        {
            int width = 3;
            width++;
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);
            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);
            bool truthValue = true;
            Console.WriteLine(truthValue);

            while (area < 50)
            {
                height++;
                area = width * height;
            }

            do
            { 
                width--;
                area = width * height;
            }
            while (area>25);
        }
    }
}
