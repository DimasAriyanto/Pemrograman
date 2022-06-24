using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrinterWindows printer;

            Console.WriteLine("Pilih Printer :  ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Laser Jet");

            Console.WriteLine("Nomer Printer [1..3] : ");
            int nomerPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomerPrinter == 1)
            {
                printer = new Epson();
                printer.Show();
                printer.Print();
            }
            else if (nomerPrinter == 2)
            {
                printer = new Canon();
                printer.Show();
                printer.Print();
            }
            else if (nomerPrinter == 3)
            {
                printer = new LaserJet();
                printer.Show();
                printer.Print();
            }
            else
            {
                Console.WriteLine("Pilihan yang anda masukkan salah");
            }

            Console.ReadKey();
        }
    }
}
