using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Meter
    {
        public delegate void Hendler();
        public static event Hendler Event;
        public void CountDay(int i)
        {
            if(i == 10)
            {Event();}
            else
            {
                Console.WriteLine("Сегодня {0}", i);
            }
        }
        public void SayCountDay()
        {
            Console.WriteLine("Сегодня 10.Пора платить.");
        }
    }
}
