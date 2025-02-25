using Patterns.Behaviour.ChainOfResponsability.Models;

namespace Patterns.Behaviour.ChainOfResponsability
{
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public AbstractHandler()
        {

        }

        public virtual VehicleInspection Handle(Car car, VehicleInspection vehicleInspection)
        {
            if (car is null)
                throw new ArgumentNullException(nameof(car));

            if (this._nextHandler != null)
                return _nextHandler.Handle(car, vehicleInspection);

            return vehicleInspection;
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }
}
