using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hasil;

            Calculator calculator = new Calculator();

            hasil = calculator.Penjumlahan(10, 2);
            CetakHasil("Hasil penjumlahan: " + hasil);

            hasil = calculator.Penjumlahan(10, 2, 3);
            CetakHasil("Hasil penjumlahan: " + hasil);

            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("Hasil pengurangan: " + hasil);

            hasil = calculator.Perkalian(5, 2);
            CetakHasil("Hasil perkalian: " + hasil);

            Console.ReadKey();

        }
        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
