using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Car
    {
        string nomer;
        public string Nomer
        {
            get { return nomer; }
        }
        public Car(string nomer)
        {
            this.nomer = nomer;
        }
    }
}
