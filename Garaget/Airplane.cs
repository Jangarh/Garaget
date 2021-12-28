namespace Garaget
{
    public class Airplane : Vehicle
    {
        protected string EnginType { get; set; }
        public Airplane(string regNo, string make, string model, string color, string engintype) : base(regNo, make, model, color)
        {
            EnginType = engintype;
        }

        public override string ToString()
        {
            return string.Format("Vehicle with Reg Number {0} and of model {1} and has the engin type of {2}.", RegNo, Model, EnginType);
        }

        public override void start() { Console.WriteLine("Airplane has Started"); }
        public override void takOff() { Console.WriteLine("Airplane took off"); }
    }
}
