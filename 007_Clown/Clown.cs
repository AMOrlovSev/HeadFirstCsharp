using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Clown
{
    internal class Clown
    {
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name +
            " and I'm " + Height + " inches tall.");
        }
    }
}
