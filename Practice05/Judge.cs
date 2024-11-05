using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Practice05_V14
{
    internal class Judge
    {
        int countSportsman;
        private int hitCount = 0;
        public delegate void Sport();
        public static event Sport Event3;
        public static event Sport Event4;
        public Judge(int countSportsman)
        {
            this.countSportsman = countSportsman;
        }
        public void TargetOn()
        {
            Console.WriteLine("Попав");
            hitCount++;
        }
        public void TargetOff()
        {
            Console.WriteLine("Не попав");
        }
        public void Count()
        {
            if (hitCount >= (countSportsman + 1) / 2)
            {
                Event3();
            }
            else
            {
                Event4();
            }
        }
        public void Success()
        {
            Console.WriteLine("Молодці!");
        }
        public void Fail()
        {
            Console.WriteLine("Треба більше тренуватись");
        }

    }
}
