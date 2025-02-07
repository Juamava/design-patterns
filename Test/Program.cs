using Azure.Messaging.ServiceBus;
using ClosedXML.Excel;
using Design_Patterns.Structural.Adapter;
using System.Text;

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
            AdapterUsage adapterUsage = new AdapterUsage();
            adapterUsage.Use();
        }
    }
}