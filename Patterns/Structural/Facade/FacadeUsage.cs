using Design_Patterns;

namespace Patterns.Structural.Facade
{
    public class FacadeUsage : IUsageStartegy
    {
        private readonly SubSystem1 primus;
        private readonly SubSystem2 highway;

        public FacadeUsage()
        {
            primus = new SubSystem1();
            highway = new SubSystem2();
        }

        public void Use()
        {
            Facade facade = new Facade(primus, highway);
            Console.WriteLine(facade.Operation());
        }
    }
}
