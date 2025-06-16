using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string model, string registrationNumber, string color, int wheels) : base(model, registrationNumber, color, 2)
        {
        }
        public override void GetInfo()
        {
            base.GetInfo();
        }
    }
}
