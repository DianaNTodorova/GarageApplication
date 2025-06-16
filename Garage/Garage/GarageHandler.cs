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
        Garage<IVehicle> garage= new Garage<IVehicle>(); //the array
        public void AddVehicle(IVehicle vehicle)
        {
            garage.Park(vehicle);
            //garage.Where(p=>p)
        }

        public void ShowVehicles()
        {
            foreach (var vehicle in garage)
            {
                Console.WriteLine(vehicle);
            }
        }

        public void RemoveVehicle()
        {
            throw new NotImplementedException();
        }

        public void CreateGarage()
        {        
            throw new NotImplementedException();
        }
    }
}
