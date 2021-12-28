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
                    new Vehicle {regNo="ABC121", make="Toyota", model="Corola", color="Green" },
                    new Vehicle {regNo="BSC654", make="BMW", model="X6", color="Blue" },
                    new Vehicle {regNo="eee333", make="Volvo", model="S60", color="Red" },
                    new Vehicle {regNo="bbb222", make="Honda", model="vvv", color="Gray" }
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
        
    }
}
