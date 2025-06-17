using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string model, string registrationNumber, string color) : base(model, registrationNumber, color, 2)
        {
        
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Motorcycle {Model} with registration number: {RegistrationNumber}, color {Color} and {Wheels} wheels! ");
        }
    }
}
