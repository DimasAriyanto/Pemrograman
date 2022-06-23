using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class LaserJet : PrinterWIndows
    {
        public override void Show()
        {
            Console.WriteLine("Laser Jet display dimension : 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("laser Jet printer printing.....");
        }
    }
}
