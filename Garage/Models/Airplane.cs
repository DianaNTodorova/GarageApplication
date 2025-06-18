
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Airplane : Vehicle
    {
        public int NumberOfEngines { get; set; }
        public Airplane(string model, string registrationNumber, string color, int numberOfEngines) : base(model, registrationNumber, color, 8)
        {
            NumberOfEngines = numberOfEngines;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Airplane {Model} with registration number: {RegistrationNumber}, color {Color}, {Wheels} wheels and number of engines {NumberOfEngines}! ");
        }
    }
}
