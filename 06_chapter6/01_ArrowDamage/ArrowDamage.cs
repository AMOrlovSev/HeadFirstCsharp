using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ArrowDamage
{
    internal class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;
        /// <summary>
        /// Contains the calculated damage.
        /// </summary>
        public int Damage { get; private set; }
        private int roll;
        /// <summary>
        /// Sets or gets the 3d6 roll.
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        private bool magic;
        /// <summary>
        /// True, если меч волшебный; false в противном случае.
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        private bool flaming;
        /// <summary>
        /// True, если меч огненный; false в противном случае.
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        /// <summary>
        /// Вычисляет повреждения в зависимости от текущих значений свойств.
        /// </summary>
        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }
        /// <summary>
        /// Конструктор вычисляет повреждения для значений Magic и Flaming по умолчанию
        /// и начального броска 3d6.
        /// </summary>
        /// <param name="startingRoll">Начальный бросок 3d6</param>
        public ArrowDamage(int startingRoll)
        {
            Roll = startingRoll;
            CalculateDamage();
        }
    }
}
