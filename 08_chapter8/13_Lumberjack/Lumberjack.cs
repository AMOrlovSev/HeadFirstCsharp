using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _13_Lumberjack
{
    internal class Lumberjack
    {
        public string Name { get; private set; }
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();
        public Lumberjack(string name)
        {
            Name = name;
        }
        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }
        public void EatFlapjack()
        {
            Console.WriteLine($"\n{Name} is eating flapjacks");
            while (flapjackStack.Count > 0)
            {
                Console.WriteLine(
                $"{Name} ate a {flapjackStack.Pop().ToString().ToLower()} flapjack");
            }
        }
    }
    enum Flapjack
    {
        Crispy,
        Soggy,
        Browned,
        Banana,
    }
}
