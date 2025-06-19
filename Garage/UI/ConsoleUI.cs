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
                        AdvancedSearchVehicle();
                        break;
                    case "7":
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
            Console.WriteLine("6. Advanced Search for vehicle");
            Console.WriteLine("7. Exit");
        }

        private void CreateGarage()
        {
            Console.Write("Enter garage capacity: ");
            if (int.TryParse(Console.ReadLine(), out int capacity))
            {
                handler.CreateGarage(capacity);
            }
            else
            {
                Console.WriteLine("Invalid number. Please try again.");
            }
        }

        private void ParkVehicle()
        {
            Console.WriteLine("Select vehicle type to park:");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Motorcycle");
            Console.WriteLine("3. Bus");
            Console.WriteLine("4. Airplane");
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
                case "3":
                    Console.Write("Enter number of seats: ");
                    int numberOfSeats = int.Parse(Console.ReadLine());
                    handler.AddVehicle(new Bus(model, regNumber, color, numberOfSeats));
                    break;
                case "4":
                    Console.Write("Enter number of engines: ");
                    int numberOfEngines = int.Parse(Console.ReadLine());
                    handler.AddVehicle(new Airplane(model, regNumber, color, numberOfEngines));
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
        private void AdvancedSearchVehicle()
        {
            Console.WriteLine("Search vehicle by model (or press enter to skip);");
            string inputModel = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputModel)) inputModel = null;

            Console.WriteLine("Search vehicle by color (or press enter to skip);");
            string inputColor = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputColor)) inputColor = null;

            Console.WriteLine("Search vehicle by registration number (or press enter to skip);");
            string inputRegNumber = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputRegNumber)) inputRegNumber = null;

            Console.WriteLine("Search vehicle by number of engines (or press enter to skip);");
            int? inputNumberEngines = int.TryParse(Console.ReadLine(), out int resultEngine) ? resultEngine : null;

            Console.WriteLine("Search vehicle by number of seats (or press enter to skip);");
            int? inputNumberSeats = int.TryParse(Console.ReadLine(), out int resultSeat) ? resultSeat : null;

            handler.AdvancedSearch(inputModel, inputColor, inputRegNumber, inputNumberEngines, inputNumberSeats);

        }


    }
}
