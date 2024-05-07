using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();

        // как в книге
        //public static string[] PickSomeCards(int numberOfCards)
        //{
        //    string[] pickedCards = new string[numberOfCards];
        //    for (int i = 0; i<numberOfCards; i++)
        //    {
        //        pickedCards[i] = RandomValue() + " of " + RandomSuit();
        //    }
        //    return pickedCards;
        //}

        //изменил PickSomeCards, чтобы не было дупликатов
        public static string[] PickSomeCards(int numberOfCards)
        {
            int maxCards = 36;
            List<string> list = new List<string>();
            string[] pickedCards = new string[numberOfCards];
            string temp;
            for (int i = 0; i < numberOfCards; i++)
            {
                temp = RandomValue() + " of " + RandomSuit();
                if (list.Contains(temp))
                {
                    i--;
                    if (i == maxCards-1)
                    {
                        break;
                    }
                }
                else
                {
                    list.Add(temp);
                }
            }
            return pickedCards = list.ToArray();
        }



        private static string RandomValue()
        {
            // получить случайное число от 6 до 14
            int value = random.Next(6, 15);
            // если это 11, вернуть строку Jack
            if (value == 11) return "Валет";
            // если это 12, вернуть строку Queen
            if (value == 12) return "Дама";
            // если это 13, вернуть строку King
            if (value == 13) return "Король";
            // если это 14, вернуть строку Ace
            if (value == 14) return "Туз";
            // если выполнение продолжается, вернуть значение в виде строки
            return value.ToString();
        }
        private static string RandomSuit()
        {
            // получить случайное число от 1 до 4
            int value = random.Next(1, 5);
            // если это 1, вернуть строку Spades
            if (value == 1) return "Пики";
            // если это 2, вернуть строку Hearts
            if (value == 2) return "Черви";
            // если это 3, вернуть строку Clubs
            if (value == 3) return "Крести";
            // если выполнение продолжается, вернуть строку Diamonds
            return "Бубны";
        }
    }
}
