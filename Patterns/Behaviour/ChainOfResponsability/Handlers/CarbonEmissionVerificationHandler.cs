using Patterns.Behaviour.ChainOfResponsability.Models;
using System.Text;

namespace Patterns.Behaviour.ChainOfResponsability.Handlers
{
    public class CarbonEmissionVerificationHandler : AbstractHandler
    {
        public override VehicleInspection Handle(Car request, VehicleInspection vehicleInspection)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Carbon Emision: ");

            if (request.CarbonEmision > 50)
                stringBuilder.Append("Rejected, you're destroying the planet!");

            vehicleInspection.Results.Add(stringBuilder.ToString());

            return base.Handle(request, vehicleInspection);
        }
    }
}
