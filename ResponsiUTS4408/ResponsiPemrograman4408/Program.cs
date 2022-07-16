using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4408
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karyawan paijo = new Karyawan(190302123, "Paijo", 3000000);
            Karyawan jono = new Karyawan(190302124, "Jono", 2000000);
            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", paijo.getNik(), paijo.getNama(), paijo.getGajiBulanan());
            Console.WriteLine("2    {0}/{1}         {2}", jono.getNik(), jono.getNama(), jono.getGajiBulanan());


            Console.WriteLine();
            Console.WriteLine("Naikkan Gaji Sebesar 10%");
            Console.WriteLine();

            paijo.NaikkanGaji(10);
            jono.NaikkanGaji(10);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", paijo.getNik(), paijo.getNama(), paijo.getGajiBulanan());
            Console.WriteLine("2    {0}/{1}         {2}", jono.getNik(), jono.getNama(), jono.getGajiBulanan());

            Console.ReadKey();
        }
    }
}
