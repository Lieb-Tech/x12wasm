using x12interpretor.Models;

namespace x12interpretor.LineProcessors
{
    public interface Ix12lineProcessor
    {
        string LineCode { get; set; }
        string CodeDescription { get; set; }
        x12lineResult ProcessLine(string line);        
    }
}
