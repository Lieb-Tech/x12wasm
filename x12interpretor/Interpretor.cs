using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x12interpretor.LineProcessors;
using x12interpretor.Models;

namespace x12interpretor
{
    public class Interpretor
    {
        private readonly List<Ix12lineProcessor> processors = new List<Ix12lineProcessor>();
        public Interpretor()
        {
            processors.Add(new x12isa());
            processors.Add(new x12beg());
            processors.Add(new x12gs());
            processors.Add(new x12st());
            processors.Add(new x12ref());
            processors.Add(new x12n1());
            processors.Add(new x12po1());
            processors.Add(new x12ctt());
        }

        public async Task<x12fileResult> ProcessFileAsync(string file)
        {
            var result = new x12fileResult() { Error = true };
            bool hasTilda = file.IndexOf('~') > -1;
            bool hasCRLF = file.IndexOf("\r\n") > -1;

            if (!hasCRLF && !hasTilda)
                return result;

            string[] lines;
            if (hasCRLF)
                lines = file.Split("\r\n");
            else
                lines = file.Split("~");

            foreach (var  line in lines)
            {
                var lineResult = await ProcessLineAsync(line);                
                lineResult.OriginalLineNumber = result.Lines.Count + 1;

                if (lineResult is not null)
                    result.Lines.Add(lineResult);
            }

            return result;
        }

        protected async Task<x12lineResult> ProcessLineAsync(string line)
        {          
            var processor = getProcessor(line);

            if (processor is null)
                return new x12lineResult() { OriginalValue = line };

            var result = processor.ProcessLine(line);
            result.LineDescription = processor.CodeDescription;            

            if (processor.PostProcessors.Any())
            {                
                foreach (var postProc  in processor.PostProcessors)
                {                    
                    await postProc.PostProcessAsync(result);
                }
            }

            return result;
        }

        protected Ix12lineProcessor getProcessor(string line)
        {
            var section = line.Split('*').First();
            var proc = processors.SingleOrDefault(z => z.LineCode == section);
            return proc;
        }
    }
}
