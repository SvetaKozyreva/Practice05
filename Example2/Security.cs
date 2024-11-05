using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Security
    {
        string name;
        public string Name
        {
            get { return name; }
        }
        public Security(string name)
        {
            this.name = name;
        }
        public void CloseParking()
        {
            Console.ForegroundColor = System.ConsoleColor.Blue;
            Console.WriteLine("Місць немає. Охоронець {0} Закрив стоянку", name);
            Parking.NotPlaces -= this.CloseParking;
        }
    }
}
