using x12interpretor.Models;

namespace x12interpretor.LinePostProcessors.Strategies
{
    public interface IStrategy
    {
        bool Process(x12lineResult lineResult, x12fieldResult fieldResult);
    }
}
