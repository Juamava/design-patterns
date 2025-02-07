namespace Design_Patterns.Structural.Adapter.Models
{
    public class RoundHole
    {
        private double radius;

        public RoundHole(double radius)
        {
            this.radius = radius;
        }

        private double GetRadius()
        {
            return radius;
        }

        public bool Fits(RoundPeg roundPeg)
        {
            var roundPegRadius = roundPeg.GetRadius();
            return this.GetRadius() >= roundPegRadius;
        }
    }
}
