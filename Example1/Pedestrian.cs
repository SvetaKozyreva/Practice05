using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Pedestrian
    {
        string name;
        public Pedestrian() { }
        public Pedestrian(string name)
        {
            this.name = name;
        }
        public void Go()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0} іду", name);

            TrafficLight.Event1 -= this.Stand;
            TrafficLight.Event2 -= this.Go;
        }
        public void Stand()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0} стою", name);
        }
    }
}
