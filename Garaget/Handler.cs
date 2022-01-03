using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    internal class Handler
    {
        private Garage<Vehicle> garage;

        public Handler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
        }

        internal void ParkDummyVehicles()
        {
            var vehicles = new List<Vehicle>()
                {
                    new Car("CAR111", "Toyota", "Corola", "Green", "Petrol"),
                    new Airplane("AIR111", "SAAB", "100", "WHite", "Double"),
                    new Airplane("AIR222", "SAAB", "100", "WHite", "Double"),
                    new Bus("BUS111","MAN", "100", "Red", 40),
                    new Boat("BOA111", "Volvo", "100", "White", 100),
                    new Boat("BOA222", "Volvo", "100", "White", 100),
                };

            foreach (var vehicle in vehicles)
            {
                if (!garage.IsFull)
                    garage.Park(vehicle);
                        
                else
                    break;
            
            }
        }

        internal IEnumerable<Vehicle> GetAll()
        {
          //var allcarsWithA = garage.Where(v => v.regNo.StartsWith("A"));
            return garage.ToList();
        }

        internal void RemoveVehicle(string regnr)
        {
            if (garage.UnPark(regnr))
            {
                Console.WriteLine($"Successfully unparked {regnr}!");
            }
            else
            {
                Console.WriteLine($"Could not find vehicle with that licence plate ({regnr}).");
            }
                    
        }

        public void FindByRegNr(string regnr)
        {
            foreach (var vehicle in garage)
            {
                if (vehicle.RegNo == regnr)
                {
                    Console.WriteLine($"Found vehicle: {vehicle.ToString()}");
                }
                
            }
        }

        public void PrintStats()
        {
            var nrofCars = 0;
            var nrofBuses = 0;
            var nrofBoats = 0;
            var nrofAirplanes = 0;

            foreach (var vehicle in garage)
            {
                if (vehicle.GetType().Name == "Car")
                {
                    nrofCars++;
                }
                if (vehicle.GetType().Name == "Bus")
                {
                    nrofBuses++;
                }
                if (vehicle.GetType().Name == "Boat")
                {
                    nrofBoats++;
                }
                if (vehicle.GetType().Name == "Airplane")
                {
                    nrofAirplanes++;
                }
            }

            Console.WriteLine("Statistics for this garage:");
            Console.WriteLine($"Cars: {nrofCars}");
            Console.WriteLine($"Airplanes: {nrofAirplanes}");
            Console.WriteLine($"Boats: {nrofBoats}");
            Console.WriteLine($"Buses: {nrofBuses}");

        }


        
    }
}
