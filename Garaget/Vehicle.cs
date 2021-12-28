using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    public class Vehicle : IVehicle
    {

        public string regNo = "ABC111";
        public string make = "BMW";
        public string model = "X5";
        public string color = "Gray";
        public string? RegNo { get { return regNo; } set { regNo = value; } }
        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Color { get { return color; } set { color = value; } }

        public Vehicle(string regNo, string make, string model, string color)
        {
            RegNo = regNo;
            Make = make;
            Model = model;
            Color = color;
        }

        public Vehicle()
        {

        }
        public override string ToString()
        {
            return string.Format("Vehicle with Reg Number {0} and of model {1}", RegNo, Model);
        }

        public virtual void start() { return; }
        //public virtual void stop() { return; }
        //public virtual void parked() { return; }
        public virtual void takOff() { return; }
        //  public override string ToString() { return ToString(); }

    }
}
