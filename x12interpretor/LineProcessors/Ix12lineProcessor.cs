using System.Collections.Generic;
using x12interpretor.LinePostProcessors;
using x12interpretor.Models;

namespace x12interpretor.LineProcessors
{
    public interface Ix12lineProcessor
    {
        List<Ix12linePostProcessor> PostProcessors { get; set; }
        string LineCode { get; set; }
        string CodeDescription { get; set; }
        x12lineResult ProcessLine(string line);        
    }
}
