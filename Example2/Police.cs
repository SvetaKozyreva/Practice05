using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Police
    {
        string name;
        public string Name { get { return name; } }
        public Police(string name)
        {
            this.name = name;
        }
        public void VideoSwitchOn()
        {
            Console.ForegroundColor = System.ConsoleColor.Magenta;
            Console.WriteLine("Поліцейський {0} ввімкнув відеоспостереження", name);
            Parking.NotPlaces -= this.VideoSwitchOn;
        }
        public void DroveOutAddress(int t)
        {
            Console.ForegroundColor = System.ConsoleColor.Magenta;
            Console.WriteLine("Поліцейський {0} приїхав на стоянку", name);
            Console.WriteLine("Спрацювала сигналізація {0} раз", t);
        }
    }
}
