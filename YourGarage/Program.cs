using System;
using System.Collections.Generic;
using YourGarage.Composition.Vehicles.Cars;

namespace YourGarage
{
    class Program
    {
        public static void Main()
        {
            var gt40Car = new GT40()
            {
                Name = "Mustang GT 40"
            };
            var hondaCrv = new HondaCRV()
            {
                Name = "CRV"
            };
            // Build a collection of all vehicles that fly
            var carCollection = new List<object>()
            {
                gt40Car,
                hondaCrv
            };
            // With a single `foreach`, have each vehicle Fly()

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
        }
    }
}
