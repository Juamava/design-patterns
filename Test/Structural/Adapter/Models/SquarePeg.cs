namespace Design_Patterns.Structural.Adapter.Models
{
    public class SquarePeg
    {
        int width;

        public SquarePeg(int width)
        {
            this.width = width;
        }

        public int GetWidth()
        {
            return width;
        }
    }
}
