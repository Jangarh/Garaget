using System .Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Garaget
{
    class Program
    {
        private static Handler handler;

        static void Main()
        {

           handler = GarageCreate();
           ShowMainMeny();

        }

        private static void ShowMainMeny()
        {
            do
            {

            Console.Clear();
            Console.WriteLine("Welcome to garage main meny");
            Console.WriteLine("1. Park some dummy wehicles");
            Console.WriteLine("2. Show all parked vehicles");
            Console.WriteLine("3. Remove vehicles");
            Console.WriteLine("4. Print garage stats");
                Console.WriteLine("Q. Exit");

                var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                        handler.ParkDummyVehicles();
                        break;   
                case "2":
                        ShowAllVehicles();
                        Console.ReadLine();
                        break;
                case "3":
                        Console.WriteLine("Input regnr of tvehicle you want to unpoark:");
                        var regnr = Console.ReadLine();
                        handler.RemoveVehicle(regnr);
                        break;
                case "4":
                        handler.PrintStats();
                        Console.ReadLine();
                        break;
                case "Q":
                    Environment.Exit(0);    
                    break;
                default:

                    break;
            }

            } while (true);
        }

        private static void ShowAllVehicles()
        {
            var vehicles = handler.GetAll();

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
                
            }
        }

        private static Handler GarageCreate()
        {
            Console.WriteLine("Welcome to the garage. How many slots?");
            int capacity = 0;

            while (!int.TryParse(Console.ReadLine(), out capacity))
            {
                Console.WriteLine("Wrong format");
            };

            var handler = new Handler(capacity);
            return handler;
        }
    }
}