using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Canon : IPrinterWindows
    {
        public void Print()
        {
            Console.WriteLine("Canon printer printing.....");
        }

        public void Show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
    }
}
