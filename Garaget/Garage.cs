using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{

    public class Garage<T> : IEnumerable<T>, IGarage<T> where T : Vehicle
    {
        private int capacity;
        private T[] vehicles;
        private int count;

        public Vehicle this[int index] => vehicles[index];
        public bool IsFull => count >= capacity;
        public int Count => count;
        public Garage(int capacity)
        {
            //Validate capacity not -23
            this.capacity = capacity;
            vehicles = new T[capacity];
        }


        public bool Park(T vehicle)
        {
            //If garage is full return false
            //Else try to park vehicle
            if (IsFull) return false;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    count++;
                    return true;
                }
            }

            return false;

        }

        public bool UnPark(string regnr)
        {
            //Does garage contain vehicle?
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null && vehicles[i].RegNo == regnr)
                {
                    vehicles[i] = null;
                    return true;
                }
            }
            //If true unpark
            //else fail = false


            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //Data to send back to caller
            foreach (var v in vehicles)
            {
                if (v != null)
                    yield return v;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }




    //public class Garage2 //: IEnumerable<Vehicle>
    //{


    //    Vehicle[] _vehicles = new Vehicle[]
    //    {
    //        new Vehicle {regNo="ABC121", make="Toyota", model="Corola", color="Green" },
    //        new Vehicle {regNo="BSC654", make="BMW", model="X6", color="Blue" },
    //        new Vehicle {regNo="eee333", make="Volvo", model="S60", color="Red" } 
    //    };


    // //public object Current
    // //{
    // //    get { throw new NotImplementedException(); }
    // //}
    // //
    // //public bool MoveNext()
    // //{
    // //    throw new NotImplementedException();
    // //}
    // //
    // //public void Reset()
    // //{
    // //    throw new NotImplementedException();
    // //}


    //    public IEnumerator<Vehicle> GetEnumerator()
    //    {
    //        yield return (Vehicle)Vehicles.GetEnumerator();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }



    //   public void Append(Vehicle vehicle)
    //   {
    //       _vehicles = Vehicles.Append(vehicle).ToArray();
    //    }
    //    public Vehicle this[int index] => Vehicles[index];
    //    public int Count => Vehicles.Length;

    //    public Vehicle[] Vehicles { get => Vehicles1; set => Vehicles1 = value; }
    //    public Vehicle[] Vehicles1 { get => _vehicles; set => _vehicles = value; }
    //    public Vehicle[] Vehicles2 { get => _vehicles; set => _vehicles = value; }

    //    //public IEnumerator<Vehicle> GetEnumerator()
    //    //    {
    //    //        return (IEnumerator<Vehicle>)vehicles.GetEnumerator();
    //    //    }
    //    //
    //    //    IEnumerator IEnumerable.GetEnumerator() => vehicles.GetEnumerator();

    //    //static void Vehicle(int i, int j)
    //    //{
    //    //    for (i = 0; i < 10; i++)
    //    //    {
    //    //        for (j = 0; j < 4; j++)
    //    //        {
    //    //            Console.WriteLine("ABC1212, BMW, x6, White");
    //    //            Console.WriteLine("DBC222, Volvo, S60, Blue");
    //    //            Console.WriteLine("JHK4321, Toyota, Corola, Red");
    //    //
    //    //        }
    //    //    }
    //    //
    //    //}







}
