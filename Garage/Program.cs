using Garage.Interfaces;
using Garage.UI;
using System.Runtime.InteropServices.Marshalling;

namespace Garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUI ui = new ConsoleUI();
            ui.StartGarage();
        }
    }
}
