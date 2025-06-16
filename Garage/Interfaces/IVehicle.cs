using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Interfaces
{
    internal interface IVehicle
    {
        string Model { get; }
        string RegistrationNumber { get; }
        string Color { get; }
        int Wheels { get; }

        void GetInfo();



    }
}
