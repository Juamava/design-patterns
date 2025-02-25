using Patterns.Behaviour.ChainOfResponsability.Models;

namespace Patterns.Behaviour.ChainOfResponsability.Handlers
{
    public class MaxSpeedVerificationHandler : AbstractHandler
    {
        public override VehicleInspection Handle(Car car, VehicleInspection vehicleInspection)
        {
            if (car.MaxSpeed > 130)
                vehicleInspection.Results.Add("MaxSpeed: This is not a car, this is a weapon! Are you nuts?");

            return base.Handle(car, vehicleInspection);
        }
    }
}
