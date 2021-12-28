namespace Garaget
{ 
    public class Motorcycle : Vehicle
    {
        public int NoOfWheels { get; set; }
        public Motorcycle(string regNo, string make, string model, string color, int noOfWheels) : base(regNo, make, model, color)
        {
            NoOfWheels = noOfWheels;
        }
        public override string ToString()
        {
            return string.Format("Vehicle with Reg Number {0} and of model {1} and has only {2} wheels.", RegNo, Model, NoOfWheels);
        }
    }

}
