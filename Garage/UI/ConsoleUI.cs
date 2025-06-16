using Garage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.UI
{
    internal class ConsoleUI : IUI
    {
        public void StartGarage()
        {
            while (true) 
            {
                Console.WriteLine("Welcome to The City Parking ");
                Console.WriteLine("\nMake a choice:\n1 Create a new garage \n2. Park a car \n3. Leave the parking \n4. Show all vehicels \n5. Search for vehicle \n6. Exit!");
                string choice= Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        break;
                    case "2":
                        Console.WriteLine("Enter a car model:");
                        string carModel= Console.ReadLine();
                        Console.WriteLine("Enter a registration number:");
                        string registrationNumber= Console.ReadLine().ToUpper();
                        Console.WriteLine("Enter a car color");
                        string carColor=Console.ReadLine();


                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        Console.WriteLine("Enter a registration number:");
                        string regNumber= Console.ReadLine().ToUpper();
                        break;
                    case "6":
                        break;

                }
            
            }
        }
    }
}
