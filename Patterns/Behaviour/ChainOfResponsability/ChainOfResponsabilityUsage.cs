using Design_Patterns;
using Patterns.Behaviour.ChainOfResponsability.Handlers;
using Patterns.Behaviour.ChainOfResponsability.Models;

namespace Patterns.Behaviour.ChainOfResponsability
{
    internal class ChainOfResponsabilityUsage : IUsageStartegy
    {
        public void Use()
        {
            Logger.Log("Chain of Responsability - Vehicle Inspection");

            CarbonEmissionVerificationHandler carbonEmissionVerificationHandler = new CarbonEmissionVerificationHandler();
            LightsVerificationHandler lightsVerificationHandler = new LightsVerificationHandler();
            MaxSpeedVerificationHandler maxSpeedVerificationHandler = new MaxSpeedVerificationHandler();

            carbonEmissionVerificationHandler
                .SetNext(lightsVerificationHandler)
                .SetNext(maxSpeedVerificationHandler);


            Car myCrazyCar = new Car()
            {
                CarbonEmision = 300,
                Lumens = 5,
                MaxSpeed = 55
            };

            VehicleInspection vehicleInspection = new VehicleInspection()
            {
                Results = new List<string>()
            };

            var vehiculeInspection = carbonEmissionVerificationHandler.Handle(myCrazyCar, vehicleInspection);

            foreach (var inspection in vehicleInspection.Results)
            {
                Logger.Log(inspection);
            }
        }
    }
}
