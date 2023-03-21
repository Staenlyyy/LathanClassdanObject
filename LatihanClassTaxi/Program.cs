using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi_Properties taxi = new Taxi_Properties();

            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            if (taxi.OnDuty == true)
            {
                taxi.PickUpPassenger();
            } else if
            (taxi.OnDuty == false)
            {
                taxi.DropOffPassenger();
            }

            Console.ReadKey();
        }
    }
}