﻿using Garage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Vehicle : IVehicle
    {
        public string Model { get; }
        public string RegistrationNumber { get; }
        public string Color { get; }

        public int Wheels { get; }

        string IVehicle.Model => Model;

        string IVehicle.RegistrationNumber => RegistrationNumber;

        string IVehicle.Color => Color;

        int IVehicle.Wheels => Wheels;

        public Vehicle(string model, string registrationNumber, string color, int wheels) 
        {
            Model=model;
            RegistrationNumber = registrationNumber;
            Color = color;
            Wheels = wheels;
        
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"The vehicle{Model} is with registration number{RegistrationNumber}, color{Color} and wheels{Wheels}! ");
        }


    }
}
