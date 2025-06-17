using Garage.Garage;
using Garage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Interfaces
{
    internal interface IHandler
    {
        void CreateGarage();
        bool RemoveVehicle(string regNumber);
        bool AddVehicle(IVehicle vehicle);



    }
}
