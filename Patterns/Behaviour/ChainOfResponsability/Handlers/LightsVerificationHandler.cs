using Patterns.Behaviour.ChainOfResponsability.Models;

namespace Patterns.Behaviour.ChainOfResponsability.Handlers
{
    internal class LightsVerificationHandler : AbstractHandler
    {
        public override VehicleInspection Handle(Car car, VehicleInspection vehicleInspection)
        {
            if (car.Lumens < 10)
                vehicleInspection.Results.Add("Lights: Rejected, the right light is not working");

            return base.Handle(car, vehicleInspection);
        }
    }
}
