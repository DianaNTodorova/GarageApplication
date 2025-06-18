using Garage.Garage;
using Garage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Interfaces
{
    public interface IHandler
    {
        void CreateGarage(int capacity);
        bool RemoveVehicle(string regNumber);
        bool AddVehicle(IVehicle vehicle);



    }
}
