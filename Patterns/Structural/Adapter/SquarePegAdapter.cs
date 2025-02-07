using Design_Patterns.Structural.Adapter.Models;

namespace Design_Patterns.Structural.Adapter
{
    public class SquarePegAdapter
    {
        private SquarePeg peg;

        public SquarePegAdapter(SquarePeg squarePegAdapter)
        {
            peg = squarePegAdapter;
        }

        public RoundPeg GetRadius()
        {
            var radius = peg.GetWidth() * Math.Sqrt(2) / 2;
            return new RoundPeg(radius);
        }
    }
}
