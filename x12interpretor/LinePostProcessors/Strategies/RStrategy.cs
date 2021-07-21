using x12interpretor.Models;

namespace x12interpretor.LinePostProcessors.Strategies
{
    public class RStrategy : IStrategy
    {
        public bool Process(x12lineResult lineResult, x12fieldResult fieldResult)
        {
            if (!fieldResult.FileValue.EndsWith("C2R") && fieldResult.FileValue.EndsWith("R"))
            { 
                lineResult.LineSuffix = "Default";
                return true;
            }

            return false;
        }
    }
}