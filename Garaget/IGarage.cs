
namespace Garaget
{
    public interface IGarage<T> where T : Vehicle
    {
        Vehicle this[int index] { get; }

        int Count { get; }
        bool IsFull { get; }

        IEnumerator<T> GetEnumerator();
        bool Park(T vehicle);
        bool UnPark(string regnr);
    }
}