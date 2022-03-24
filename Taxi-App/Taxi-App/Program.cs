using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            Console.WriteLine("--- DATA DRIVER TAXI ---");
            Console.WriteLine();

            taxi.DriverName = "Dimas Ariyanto";
            taxi.OnDuty = true;
            taxi.NumPassanger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Taxi taxi2 = new Taxi();

            Console.WriteLine();

            taxi2.DriverName = "Hafis Faza";
            taxi2.OnDuty = false;
            taxi2.NumPassanger = 0;

            taxi2.TaxiInfo();
            taxi2.PickUpPassanger();
            taxi2.DropOffPassanger();

            Console.ReadKey();

        }
    }
}
