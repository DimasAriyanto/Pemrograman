using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class LaserJet : IPrinterWindows
    {
        public void Print()
        {
            Console.WriteLine("laser Jet printer printing.....");
        }
        public void Show()
        {
            Console.WriteLine("Laser Jet display dimension : 10*11");
        }
    }
}
