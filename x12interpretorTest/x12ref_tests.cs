using x12interpretor.LineProcessors;
using Xunit;

namespace x12interpretorTest
{
    public class x12ref_tests
    {
        const string line1 = @"REF*DP*020290*Department\";
        
        private readonly x12ref interpreter = new x12ref();

        [Theory]
        [InlineData(line1, "DP", 1)]

        [InlineData(line1, "020290", 2)]

        [InlineData(line1, "Department", 3)]

        public void REFTests(string line, string expected, int expectedField)
        {
            var results = interpreter.ProcessLine(line);

            Assert.Equal(line, results.OriginalValue);
            Assert.Equal("REF", results.LineCode);
            Assert.Equal(expected, results.Fields[expectedField - 1].FileValue);
            Assert.Equal(expectedField, results.Fields[expectedField - 1].Field.Ordinal);
        }
    }
}
