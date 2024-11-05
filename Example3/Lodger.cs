using Example3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Lodger
    {
        public static string name;
        public static int check;
        public static int duty;
        public Lodger(string name, int check, int duty)
        {
            Lodger.name = name;
            Lodger.check = check;
            Lodger.duty = duty;
        }
        public void Payment()
        {
            int temp = Lodger.check;
            Lodger.check -= duty;
            Console.WriteLine("{0} заплатил {1}", Lodger.name, duty);
            Lodger.duty = 0;
            Console.WriteLine(" На счету было {0}", temp);
            Console.WriteLine(" На счету осталось {0}", check);
        }
    }
}
