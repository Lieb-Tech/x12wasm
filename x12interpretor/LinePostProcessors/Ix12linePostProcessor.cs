using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using x12interpretor.Models;

namespace x12interpretor.LinePostProcessors
{
    public interface Ix12linePostProcessor
    {
        Task PostProcessAsync(x12lineResult result);
    }
}
