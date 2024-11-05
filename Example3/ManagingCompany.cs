using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class ManagingCompany
    {
        public Lodger loader;
        public void ReportCheck()
        {
            Console.WriteLine("Ваш долг {0}", Lodger.duty);
        }
    }
}
