using x12interpretor.LineProcessors;
using Xunit;

namespace x12interpretorTest
{
    public class x12st_tests
    {
        const string line1 = @"ST*850*0001\";
        const string line2 = @"ST*832*0002\";
        private readonly x12st interpreter = new x12st();

        [Theory]
        [InlineData(line1, "850", 1)]
        [InlineData(line2, "832", 1)]

        [InlineData(line1, "0001", 2)]
        [InlineData(line2, "0002", 2)]

        public void STTests(string line, string expected, int expectedField)
        {
            var results = interpreter.ProcessLine(line);

            Assert.Equal(line, results.OriginalValue);
            Assert.Equal("ST", results.LineCode);
            Assert.Equal(expected, results.FieldResults[expectedField - 1].FileValue);
            Assert.Equal(expectedField, results.FieldResults[expectedField - 1].Field.Ordinal);
        }
    }
}
