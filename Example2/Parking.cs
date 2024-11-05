using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Parking
    {
        public delegate void SignalTriggeredEventHadler(int k);
        public static event SignalTriggeredEventHadler SignalTriggered;
        public delegate void NotPlacesEventHadler();
        public static event NotPlacesEventHadler NotPlaces;

        bool therePlaces;
        string adr;
        int Allplaces;
        List<Car> cars;
        int t;
        public bool TherePlaces
        {
            get { return therePlaces; }
        }
        public Parking(string adr, int Allplaces)
        {
            this.adr = adr;
            this.Allplaces = Allplaces;
            cars = new List<Car>(0);
            this.therePlaces = true;
            t = 0;
        }
        public void PushCar(Car car)
        {
            Random o = new Random();
            if ((NotPlaces != null) && cars.Count > Allplaces - 1)
            {
                NotPlaces();
                therePlaces = false;
            }
            else
            {
                cars.Add(car);
                Console.ForegroundColor = System.ConsoleColor.Green;
                Console.WriteLine("На стоянку прибула" + car.Nomer);
                int x = o.Next(1, 8);
                if (x == 1)
                {
                    t++;
                    SignalTriggered(t);
                }
            }
        }
    }
}
