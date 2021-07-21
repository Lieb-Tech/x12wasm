using x12interpretor.Models;

namespace x12interpretor.LinePostProcessors.Strategies
{
    public class C2GStrategy : IStrategy
    {
        public bool Process(x12lineResult lineResult, x12fieldResult fieldResult)
        {
            if (fieldResult.FileValue.EndsWith("C2G"))
            {
                lineResult.LineSuffix = "CII GPO";                
                return true;
            }

            return false;
        }
    }
}