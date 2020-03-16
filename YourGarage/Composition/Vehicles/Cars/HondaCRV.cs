using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Composition.Vehicles.Cars
{
    class HondaCRV : Car
    {
        public bool IsFwd { get; set; }
        public bool HasRoofRack { get; set; }

        public void Towing()
        {
            if (HasRoofRack)
            {
                Console.WriteLine("You are pulling a trailer...");
            }
            else
            {
                Console.WriteLine("If you want to haul something, you need a hitch.");
            }
        }
    }
}
