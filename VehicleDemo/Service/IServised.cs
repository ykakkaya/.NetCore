using VehicleDemo.Model;

namespace VehicleDemo.Service
{
    public interface IServised
    {
        Vehicle SelectVehicle(string type, int id);
    }
}
