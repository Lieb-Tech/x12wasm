using x12interpretor.Models;

namespace x12interpretor.LinePostProcessors.Strategies
{
    public class C2RStrategy : IStrategy
    {
        public bool Process(x12lineResult lineResult, x12fieldResult fieldResult)
        {
            if (fieldResult.FileValue.EndsWith("C2R")) 
            { 
                lineResult.LineSuffix = "CII Default"; 
                return true;
            }

            return false;
        }
    }
}