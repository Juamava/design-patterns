using Design_Patterns.Structural.Adapter.Models;

namespace Design_Patterns.Structural.Adapter
{
    public class AdapterUsage : IUsageStartegy
    {
        public void Use()
        {
            Logger.Log("Adapter pattern");

            // 1. Create hole.
            RoundHole roundHole = new RoundHole(20);

            // 2. Create 3D Forms.
            RoundPeg roundPeg = new RoundPeg(20);
            RoundPeg secondRoundPeg = new RoundPeg(21);

            SquarePeg squarePeg = new SquarePeg(29);

            // 3. Validate
            if (roundHole.Fits(roundPeg))
                Logger.Log("The first round peg fits in the round hole");

            if (!roundHole.Fits(secondRoundPeg))
                Logger.Log("The second round peg does not fit in the round hole");

            var lastRoundPeg = new SquarePegAdapter(squarePeg).GetRadius();

            // 4. Validate the square peg.
            if (roundHole.Fits(lastRoundPeg))
                Logger.Log("The square fits!");
            else
                Logger.Log($"The square does not fit with radius: {lastRoundPeg.GetRadius().ToString()}");
        }
    }
}
