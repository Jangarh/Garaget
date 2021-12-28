namespace Garaget
{
    public class Car : Vehicle
    {
        public string Fueltype { get; set; }
        public Car(string regNo, string make, string model, string color, string fueltype) : base(regNo, make, model, color)
        {
            this.Fueltype = fueltype;
        }

        public override string ToString()
        {
            return string.Format("Vehicle with Reg Number {0} and of model {1} and has a {2} as a fueltype.", RegNo, Model, Fueltype);
        }
    }
}
