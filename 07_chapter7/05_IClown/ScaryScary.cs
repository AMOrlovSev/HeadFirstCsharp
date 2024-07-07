using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IClown
{
    internal class ScaryScary : FunnyFunny, IScaryClown
    {
        private readonly int scaryThingCount;
        public ScaryScary(string funnyThingHave, int scaryThingCount) : base(funnyThingHave)
        {
            this.scaryThingCount = scaryThingCount;
        }
        public string ScaryThingIHave 
        { get 
            {
                string r_scary = scaryThingCount + "spiders.";
                return r_scary; 
            } 
        }
        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}!");
        }
    }
}
