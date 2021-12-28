namespace Garaget
{
    public class Bus : Vehicle
    {
        public int NuOfSeats { get; set; }
        public Bus(string regNo, string make, string model, string color, int nuofseats) : base(regNo, make, model, color)
        {
            NuOfSeats = nuofseats;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" and has the total of {0} seats.", NuOfSeats);
        }
    }
}
