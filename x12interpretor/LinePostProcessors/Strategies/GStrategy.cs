using x12interpretor.Models;

namespace x12interpretor.LinePostProcessors.Strategies
{
    public class GStrategy : IStrategy
    {
        public bool Process(x12lineResult lineResult, x12fieldResult fieldResult)
        {
            if (!fieldResult.FileValue.EndsWith("C2G") && fieldResult.FileValue.EndsWith("G"))
            { 
                lineResult.LineSuffix = "GPO";
                return true;
            }

            return false;
        }
    }
}