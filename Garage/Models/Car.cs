using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Car : Vehicle
    {
        public Car(string model, string registrationNumber, string color) : base(model, registrationNumber, color, 4)
        {
            
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Car {Model} with registration number: {RegistrationNumber}, color {Color} and {Wheels} wheels! ");
        }
    }
}
