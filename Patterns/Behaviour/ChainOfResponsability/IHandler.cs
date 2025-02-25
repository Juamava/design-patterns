using Patterns.Behaviour.ChainOfResponsability.Models;

namespace Patterns.Behaviour.ChainOfResponsability
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        VehicleInspection Handle(Car request, VehicleInspection vehicleInspection);
    }
}
