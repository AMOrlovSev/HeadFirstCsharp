using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_WPF_SwordDamage_Final
{
    class SwordDamage
    {
        private const int BASE_DAMAGE = 3;
        private int roll;
        private int flaming;
        private decimal magic;
        public int Damage { get; private set; }
        public int Roll 
        {
            get {return roll;}
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        public int Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        public decimal Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        private int CalculateDamage()
        {
            return Damage = (int)(Roll * Magic) + Flaming + BASE_DAMAGE;
        }

        public SwordDamage(int rollX3) 
        {
            Roll = rollX3;
            CalculateDamage();
        }
    }
}
