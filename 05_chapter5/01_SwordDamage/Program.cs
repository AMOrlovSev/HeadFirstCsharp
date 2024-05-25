using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace _01_SwordDamage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //моё
            /*
            while (true)
            {
                SwordDamage swordDamage = new SwordDamage();
                Random random = new Random();
                swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char result = Console.ReadKey().KeyChar;
                switch (result)
                {
                    case '0':
                        swordDamage.CalculateDamage();
                        break;
                    case '1':
                        swordDamage.SetMagic(true);
                        swordDamage.CalculateDamage();
                        break;
                    case '2':
                        swordDamage.CalculateDamage();
                        swordDamage.SetFlaming(true);
                        break;
                    case '3':
                        swordDamage.SetMagic(true);
                        swordDamage.CalculateDamage();
                        swordDamage.SetFlaming(true);
                        break;
                    default:
                        break;
                }
                if (result == '0' || result == '1' || result == '2' || result == '3')
                    Console.WriteLine("\nRolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP");
                else
                    Console.WriteLine("\nPress any key to continue…");
            }
            */

            //по книге
            Random random = new Random();
            SwordDamage swordDamage = new SwordDamage();
            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, " +
                "3 for both, anything else to quit: ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;
                int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                swordDamage.Roll = roll;
                swordDamage.SetMagic(key == '1' || key == '3');
                swordDamage.SetFlaming(key == '2' || key == '3');
                Console.WriteLine("\nRolled " + roll + " for " + swordDamage.Damage + " HP\n");
            }

        }
    }
}
