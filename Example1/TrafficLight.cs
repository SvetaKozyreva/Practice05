using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class TrafficLight
    {
        public delegate void Hadler();
        public static event Hadler Event1;
        public static event Hadler Event2;
        public void ChangeLight(int i)
        {
            if (i % 2 == 0)
            { Event2(); }
            else
            { Event1(); }
        }
        public void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Горить червоний");
        }
        public void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Горить зелений");
        }
    }
}
