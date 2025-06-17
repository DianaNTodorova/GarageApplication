using Garage.Interfaces;
using Garage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Garage
{
    internal class GarageHandler : IHandler
    {
        private Garage<IVehicle> garage;

        public GarageHandler(Garage<IVehicle> garage)
        {
            this.garage = garage;
        }

        public bool AddVehicle(IVehicle vehicle)
        {
            if (garage is null)
            {
                Console.WriteLine("Please create a garage first.");
                return false;
            }
            return garage.Park(vehicle);
           
        }

        public void ShowVehicles()
        {
            foreach (var vehicle in garage) // I am stuck here!
            {
                vehicle.GetInfo();
            }
        }

        public bool RemoveVehicle()
        {
            throw new NotImplementedException();
        }

        public void CreateGarage()
        {
            Console.Write("Enter garage capacity: ");
            if (int.TryParse(Console.ReadLine(), out int capacity))
            {
                garage = new Garage<IVehicle>(capacity);
                Console.WriteLine($"Garage created with capacity {capacity}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
