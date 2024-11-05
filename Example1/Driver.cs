using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Driver
    {
        string name;
        public Driver() { }
        public Driver(string name)
        {
            this.name = name;
        }
        public void Ride()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0} їду", name);

            TrafficLight.Event1 -= this.Ride;
            TrafficLight.Event2 -= this.Stand;
        }
        public void Stand()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0} стою", name);
        }
    }
}
