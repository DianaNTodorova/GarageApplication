using Garage.Interfaces;
using Garage.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Garage
{
    public class Garage<T> : IEnumerable<T> where T : IVehicle
    {
        private T[] vehicles; //array
        private int count=0;
        private int capacity;

        public Garage(int capacity)
        {
            this.capacity = capacity;
            vehicles = new T[capacity];
        }

        public IEnumerator<T> GetEnumerator()
        {
            //Only return vehicles not null!
            for (int i = 0; i < count; i++)
            {
                yield return vehicles[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Park(T vehicle)
        {
            if (capacity <= count)
            { return false; }

            else
            {
                vehicles[count++] = vehicle;
                Console.WriteLine($"The vehicle with {vehicle.RegistrationNumber} registration number is parked!");
                return true;
            }

        }

        public bool UnPark(T vehicle)
        {
            int index = Array.FindIndex(vehicles, 0, count, v => v != null && v.RegistrationNumber == vehicle.RegistrationNumber);

            if (index == -1)
            {
                Console.WriteLine("Vehicle not found.");
                return false;
            }


            vehicles[index] = default!;
            Console.WriteLine($"The vehicle with {vehicle.RegistrationNumber} registration number is unparked!");
            return true;
        }


    }
}
