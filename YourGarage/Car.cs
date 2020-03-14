using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Car
    {
        public FuelLevel FuelLevel { get; set; }
        public CarColor CarColor { get; set; }
        public int Occupancy { get; set; }

        public Car()
        {

        }

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

        public void Driving(string location)
        {
            Console.WriteLine($"You are driving this {CarColor} to {location}.");
        }

        public void Braking()
        {
            Console.WriteLine($"When slowing down this {Occupancy} person vehicle, be careful.");
        }

    }
    
    enum CarColor
    {
        red,
        yellow,
        blue,
        green,
        orange,
        purple
    }

    enum FuelLevel
    {
        Empty,
        Quarter,
        Half,
        ThreeQuarters,
        Full
    }
}
