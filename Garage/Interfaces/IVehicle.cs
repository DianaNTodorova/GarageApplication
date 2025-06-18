using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Interfaces
{
    public interface IVehicle
    {
        public string Model { get; }
        public string RegistrationNumber { get; }
        public string Color { get; }
        public int Wheels { get; }

        void GetInfo();

    }
}
