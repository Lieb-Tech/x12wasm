using x12interpretor.Models;

namespace x12interpretor.LinePostProcessors.Strategies
{
    public class C2PStrategy : IStrategy
    {
        public bool Process(x12lineResult lineResult, x12fieldResult fieldResult)
        {
            if (fieldResult.FileValue.EndsWith("C2P"))
            {
                lineResult.LineSuffix = "CII 340B";
                return true;
            }

            return false;
        }
    }
}