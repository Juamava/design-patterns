namespace Design_Patterns.Structural.Adapter.Models
{
    public class RoundPeg
    {
        double radius;

        public RoundPeg(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return radius;
        }
    }
}
