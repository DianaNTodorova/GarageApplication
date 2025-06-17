using Garage.Garage;
using Garage.Interfaces;
using Garage.Models;
using System;

namespace Garage.UI
{
    internal class ConsoleUI : IUI
    {
        private GarageHandler handler = new GarageHandler();

        public void StartGarage()
        {
            while (true)
            {
                PrintMenu();
                string choice = Console.ReadLine()?.Trim();

                switch (choice)
                {
                    case "1":
                        CreateGarage();
                        break;
                    case "2":
                        ParkVehicle();
                        break;
                    case "3":
                        UnparkVehicle();
                        break;
                    case "4":
                        handler.ShowVehicles();
                        break;
                    case "5":
                        SearchVehicle();
                        break;
                    case "6":
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("\nWelcome to The City Parking");
            Console.WriteLine("Make a choice:");
            Console.WriteLine("1. Create a new garage");
            Console.WriteLine("2. Park a vehicle");
            Console.WriteLine("3. Leave the parking");
            Console.WriteLine("4. Show all vehicles");
            Console.WriteLine("5. Search for vehicle");
            Console.WriteLine("6. Exit");
        }

        private void CreateGarage()
        {
            handler.CreateGarage();
        }

        private void ParkVehicle()
        {
            Console.WriteLine("Select vehicle type to park:");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Motorcycle");
            string typeChoice = Console.ReadLine()?.Trim();

            Console.Write("Enter model: ");
            string model = Console.ReadLine();

            Console.Write("Enter registration number: ");
            string regNumber = Console.ReadLine()?.ToUpper();

            Console.Write("Enter color: ");
            string color = Console.ReadLine();

            switch (typeChoice)
            {
                case "1":
                    handler.AddVehicle(new Car(model, regNumber, color));
                    break;
                case "2":
                    handler.AddVehicle(new Motorcycle(model, regNumber, color));
                    break;
                default:
                    Console.WriteLine("Invalid vehicle type.");
                    break;
            }
        }

        private void UnparkVehicle()
        {
            Console.Write("Enter registration number to unpark: ");
            string regNumber = Console.ReadLine()?.ToUpper();

            if (!handler.RemoveVehicle(regNumber))
            {
                Console.WriteLine("Vehicle not found or could not be removed.");
            }
        }

        private void SearchVehicle()
        {
            Console.Write("Search by registration number, color, or model: ");
            string input = Console.ReadLine();
            handler.Search(input);
        }
    }
}
