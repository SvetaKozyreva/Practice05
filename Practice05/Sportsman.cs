using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practice05_V14.Judge;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice05_V14
{
    internal class Sportsman
    {
        int number;
        bool hitTarget;
        public static event Sport Event1;
        public static event Sport Event2;
        public Sportsman(int number)
        {
            this.number = number;
        }
        public bool HitTarget { get { return hitTarget; }}
        public void Shoot()
        {
            Random random = new Random();
            hitTarget = random.Next(2) == 1;
            if (hitTarget)
            {
                Event1();
            }
            else
            {
                Event2();
            }
        }
        public void Vivod()
        {
            Console.Write($"Спортсмен {number} \t");
        }
    }
}
