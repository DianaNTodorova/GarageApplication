using Garage.Interfaces;
using Garage.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Garage
{
    internal class Garage<T> : IEnumerable<T> where T : IVehicle
    {
        private T[] vehicle;
        private int count=0;
        private int capacity;

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return vehicle[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Park(T t)
        {

        }

        public void UnPark(T t)
        {
        }

    }
}
