using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public Bus(string model, string registrationNumber, string color, int numberOfSeats) : base(model, registrationNumber, color, 8)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Bus {Model} with registration number: {RegistrationNumber}, color {Color}, {Wheels} wheels and number of seats {NumberOfSeats}! ");
        }
    }
}
