using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Aircraft
    {
        public FuelLevel FuelLevel { get; set; }
        public VehicleColor CarColor { get; set; }
        public int Occupancy { get; set; }


        public void Refuel()
        {
            switch (FuelLevel)
            {
                case FuelLevel.Empty:
                    Console.WriteLine("Get to walking!");
                    break;
                case FuelLevel.Quarter:
                    Console.WriteLine("Probably should think about stopping for fuel soon");
                    break;
                case FuelLevel.Half:
                    Console.WriteLine("Queue the Journey....");
                    break;
                case FuelLevel.ThreeQuarters:
                    Console.WriteLine("Plenty of miles to go.");
                    break;
                case FuelLevel.Full:
                    Console.WriteLine("No worries here!");
                    break;
                default:
                    break;
            }
        }

        public void Flying()
        {
            Console.WriteLine("You are flying the plane");
        }

        public void Landing()
        {
            Console.WriteLine("You are landing the plane");
        }
    }
}
