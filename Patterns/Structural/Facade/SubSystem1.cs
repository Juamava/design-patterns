namespace Patterns.Structural.Facade
{
    public class SubSystem1 : ISubSystem1
    {
        public SubSystem1()
        {

        }

        public string DoYourThing()
        {
            return "Sub system 1 : OK";
        }
    }

    public interface ISubSystem1
    {
        string DoYourThing();
    }
}
