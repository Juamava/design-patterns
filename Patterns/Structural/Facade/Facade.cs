using System.Text;

namespace Patterns.Structural.Facade
{
    public class Facade
    {
        protected ISubSystem1 _subSystem1;
        protected ISubSystem2 _subSystem2;

        public Facade(ISubSystem1 subSystem1, ISubSystem2 subSystem2)
        {
            _subSystem1 = subSystem1;
            _subSystem2 = subSystem2;
        }

        public string Operation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(_subSystem1.DoYourThing());
            stringBuilder.AppendLine(_subSystem2.DoYourThing());
            return stringBuilder.ToString();
        }
    }
}
