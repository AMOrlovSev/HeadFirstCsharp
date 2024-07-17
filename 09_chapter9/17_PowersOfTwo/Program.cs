using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _17_PowersOfTwo
{
    class PowersOfTwo : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            var maxPower = Math.Round(Math.Log(int.MaxValue, 2));
            for (int power = 0; power < maxPower; power++)
                yield return (int)Math.Pow(2, power);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in new PowersOfTwo())
                Console.Write($" {i}");
        }
    }
}
