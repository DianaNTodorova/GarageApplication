using Garage.Interfaces;
using Garage.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage.Garage
{
    public class GarageHandler : IHandler
    {
        private Garage<IVehicle> garage = null!;

        public bool AddVehicle(IVehicle vehicle)
        {
            if (garage is null)
            {
                Console.WriteLine("Please create a garage first.");
                return false;
            }

            bool exists = garage.Any(v => v.RegistrationNumber == vehicle.RegistrationNumber);
            if (exists)
            {
                Console.WriteLine("The vehicle with this registration number already exists.");
                return false;
            }

            return garage.Park(vehicle);
        }

        public void ShowVehicles()
        {
            if (!garage.Any())
            {
                Console.WriteLine("No vehicles in garage.");
                return;
            }

            foreach (var vehicle in garage)
            {
                vehicle.GetInfo();
            }
        }

        public void Search(string input)
        {
            var result = garage.Where(v =>
                v.Model.Contains(input, StringComparison.OrdinalIgnoreCase) ||
                v.Color.Contains(input, StringComparison.OrdinalIgnoreCase) ||
                v.RegistrationNumber.Contains(input, StringComparison.OrdinalIgnoreCase));

            foreach (var v in result)
            {
                Console.WriteLine($"- Found -\nModel: {v.Model}\nColor: {v.Color}\nRegistration number: {v.RegistrationNumber}");
            }

            if (!result.Any())
            {
                Console.WriteLine("No vehicles found.");
            }
        }

        public bool RemoveVehicle(string regNumber)
        {
            IVehicle? found = garage.FirstOrDefault(v => v.RegistrationNumber.Equals(regNumber, StringComparison.OrdinalIgnoreCase));
            if (found != null)
            {
                garage.UnPark(found);
                return true;
            }

            Console.WriteLine("Vehicle with that registration number not found.");
            return false;
        }

        public void CreateGarage(int capacity)
        {
            garage = new Garage<IVehicle>(capacity);
            Console.WriteLine($"Garage created with capacity {capacity}.");
        }

        public void AdvancedSearch(string? model = null, string? color = null, string? regNumber = null, int? numberOfEngines = null, int? numberOfSeats = null)
        {
            var filter = garage.Where(v =>
        (model == null || v.Model.Equals(model, StringComparison.OrdinalIgnoreCase)) &&
        (color == null || v.Color.Equals(color, StringComparison.OrdinalIgnoreCase)) &&
        (regNumber == null || v.RegistrationNumber.Equals(regNumber, StringComparison.OrdinalIgnoreCase)) &&
        (
            numberOfSeats == null ||
            (v is Bus bus && bus.NumberOfSeats == numberOfSeats)
        ) &&
        (
            numberOfEngines == null ||
            (v is Airplane plane && plane.NumberOfEngines == numberOfEngines)
        )
    );

            if (!filter.Any())
            {
                Console.WriteLine("Vehicle not found");
                return;
            }

            foreach (var v in filter)
            {
                Console.WriteLine("Search found:");
                v.GetInfo();
            }
        }

    }
}
