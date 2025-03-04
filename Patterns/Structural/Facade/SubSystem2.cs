namespace Patterns.Structural.Facade
{
    public class SubSystem2 : ISubSystem2
    {
        public string DoYourThing()
        {
            return "Sub system 2 : OK";
        }
    }

    public interface ISubSystem2
    {
        string DoYourThing();
    }
}
