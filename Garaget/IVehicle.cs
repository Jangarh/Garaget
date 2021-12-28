namespace Garaget
{
    public interface IVehicle
    {
        string Color { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        string? RegNo { get; set; }

        void start();
        void takOff();
        string ToString();
    }
}