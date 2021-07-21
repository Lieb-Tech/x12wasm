using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using x12interpretor.LinePostProcessors.Strategies;
using x12interpretor.Models;

namespace x12interpretor.LinePostProcessors
{
    public class x12bePostProcessor : Ix12linePostProcessor
    {
        private readonly List<IStrategy> strategies = new List<IStrategy>();
        public x12bePostProcessor()
        {
            strategies.Add(new GStrategy());
            strategies.Add(new RStrategy());
            strategies.Add(new PStrategy());

            strategies.Add(new C2GStrategy());
            strategies.Add(new C2RStrategy());
            strategies.Add(new C2PStrategy());
        }

        public async Task PostProcessAsync(x12lineResult result)
        {            
            var poName = result.FieldResults.FirstOrDefault(z => z.Field.Ordinal == 3);
            if (poName is null)
                return;

            foreach (var s in strategies)
            {
                if (s.Process(result, poName))
                    break;
            }
        }
    }
}
