using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    internal class Car : Vehicle
    {
        public Car(string model, string registrationNumber, string color, int wheels) : base(model, registrationNumber, color, wheels)
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine($"The vehicle {Model} is with registration number: {RegistrationNumber}, color {Color} and wheels {Wheels}! ");
        }
    }
}
