using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using x12interpretor.Models;

namespace x12interpretor.LinePostProcessors
{
    public class x12po1PostProcessor : Ix12linePostProcessor
    {
        protected x12lineResult lineResult;
        public async Task PostProcessAsync(x12lineResult result)
        {
            lineResult = result;

            // find the N4, next will be NDC
            var codeOrdinal = result.FieldResults.FirstOrDefault(z => z.FileValue == "N4")?.Field.Ordinal;

            // if not in file
            if (codeOrdinal is null)
                return;

            var val = result.FieldResults.FirstOrDefault(z => z.Field.Ordinal == codeOrdinal.Value + 1);
            await processFieldAsync(val);
        }

        protected async Task processFieldAsync(x12fieldResult result)
        {
            // validate the field
            if (result is null || string.IsNullOrWhiteSpace(result.FileValue) || result.FileValue.Length != 11)
                return;

            // make sure the dictionary is initialied
            if (result.ExtraValues is null)
                result.ExtraValues = new();

            // convert 11 to 10
            var ndc10 = getNDC10(result.FileValue);           
            result.ExtraValues.Add("NDC 10", ndc10);

            var ndc = await processNDCAsync(ndc10);

            if (ndc is null)
            {
                result.ExtraValues.Add("openFDA", "Not founnd");
                lineResult.OriginalLineSuffix = "ndc not found";
            }
            else
            {
                var data = $"{ndc.results[0].brand_name} - {ndc.results[0].active_ingredients[0].name} {ndc.results[0].active_ingredients[0].strength}";
                result.ExtraValues.Add("openFDA", data);
                lineResult.OriginalLineSuffix = data;
            }
        }

        protected async Task<openFDARoot> processNDCAsync(string ndc10)
        {
            string key = "6YCE9aEudJjl1q1AbrzD7nPZ1TVCcZ0Mvw6esACj";
            var cli = new HttpClient();
            var url = $"https://api.fda.gov/drug/ndc.json?api_key={key}&search=packaging.package_ndc:\"{ndc10}\"&limit=1";

            try
            {
                var json = await cli.GetStringAsync(url);

                if (json.Contains("NOT_FOUND"))
                    return null;
                
                return System.Text.Json.JsonSerializer.Deserialize<openFDARoot>(json);                                    
            }
            catch (Exception ex)
            {
                var z = ex.Message;
                return null;
            }
        }

        protected string getNDC10(string ndc11)
        {
            if (ndc11[0] == '0')
                // 1234 5678 90 (skip 0)
                return $"{ndc11.Substring(1, 4)}-{ndc11.Substring(5, 4)}-{ndc11.Substring(9, 2)}";
            else
                // 01234 678 90 (skip 5)
                return $"{ndc11.Substring(0, 5)}-{ndc11.Substring(6, 3)}-{ndc11.Substring(9, 2)}";
        }
    }
}
