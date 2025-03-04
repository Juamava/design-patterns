using Design_Patterns.Structural.Adapter;
using Patterns.Behaviour.ChainOfResponsability;
using Patterns.Structural.Facade;

namespace Test
{
    public class QuoteCanonicalModel
    {
        public decimal Cost { get; set; }
        public string Level { get; set; }
    }

    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Chain of responsability
            //ChainOfResponsabilityUsage chainOfResponsabilityUsage = new ChainOfResponsabilityUsage();
            //chainOfResponsabilityUsage.Use();

            // Adapter
            //AdapterUsage adapterUsage = new AdapterUsage();
            //adapterUsage.Use();

            // Facade
            FacadeUsage facade = new FacadeUsage();
            facade.Use();
        }
    }
}