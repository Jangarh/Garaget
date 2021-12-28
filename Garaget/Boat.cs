namespace Garaget
{
    public class Boat : Vehicle
    {
        public double Length { get; set; }
        public Boat(string regNo, string make, string model, string color, double length) : base(regNo, make, model, color)
        {
            Length = length;
        }

        public override string ToString()
        {
            return string.Format("Vehicle with Reg Number {0} and of model {1} and has the length of {2}.", RegNo, Model, Length);
        }
    }
}
