using x12interpretor.LineProcessors;
using Xunit;

namespace x12interpretorTest
{
    public class x12gs_tests
    {
        const string line1 = @"GS*PO*177667227*PSG*20200424*1131*200000000*X*004010\";

        private readonly x12gs interpreter = new x12gs();

        [Theory]
        [InlineData(line1, "PO", 1)]
        [InlineData(line1, "177667227", 2)]
        [InlineData(line1, "PSG", 3)]
        [InlineData(line1, "20200424", 4)]
        [InlineData(line1, "1131", 5)]
        [InlineData(line1, "200000000", 6)]
        [InlineData(line1, "X", 7)]
        [InlineData(line1, "004010", 8)]

        public void GSTests(string line, string expected, int expectedField)
        {
            var results = interpreter.ProcessLine(line);

            Assert.Equal(line, results.OriginalValue);
            Assert.Equal("GS", results.LineCode);
            Assert.Equal(expected, results.Fields[expectedField - 1].FileValue);
            Assert.Equal(expectedField, results.Fields[expectedField - 1].Field.Ordinal);
        }
    }
}
