using Garage.Interfaces;
using Garage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Garage.Garage
{
    public class GarageHandler : IHandler
    {
        private Garage<IVehicle> garage = null!;

        //public GarageHandler(Garage<IVehicle> garage)
        //{
        //    this.garage = garage;
        //}

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
            foreach (var vehicle in garage) 
            {
                vehicle.GetInfo();
            }
        }

        public void Search(string input ) 
        {
            var sortedByRef = garage.Where(v => v.RegistrationNumber.Contains(input, StringComparison.OrdinalIgnoreCase) 
            || v.Color.Contains(input, StringComparison.OrdinalIgnoreCase) 
            || v.Model.Contains(input, StringComparison.OrdinalIgnoreCase));
            foreach (var vehicle in sortedByRef)
            {
                Console.WriteLine($"- Found - \n Model: {vehicle.Model} \n Color: {vehicle.Color} \n Registration number: {vehicle.RegistrationNumber}");
            }

            if (!sortedByRef.Any())
            {
                Console.WriteLine("No vehicles found.");
            }
        
        }


        public bool RemoveVehicle(string regNumber)
        {

            IVehicle? found = garage.FirstOrDefault(v => v.RegistrationNumber == regNumber);

            if (found != null)
            {
                garage.UnPark(found);
                return true;
            }
            else
            {
                Console.WriteLine("The vehicle with this registration number is not found.");
                return false;
            }
        }

        public void CreateGarage(int capacity)
        {
          
            garage = new Garage<IVehicle>(capacity); 
            Console.WriteLine($"Garage created with capacity {capacity}.");
          
        }


    }
}
