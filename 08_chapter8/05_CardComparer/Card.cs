using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CardComparer
{
    internal class Card
    {
        public Value Value { get; private set; }
        public Suit Suit { get; private set; }
        public string Name { get { return $"{Value} of {Suit}"; } }
        public Card(Suit suit, Value value) 
        {
            this.Suit = suit;
            this.Value = value;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
