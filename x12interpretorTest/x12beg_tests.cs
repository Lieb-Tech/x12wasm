using x12interpretor.LineProcessors;
using Xunit;

namespace x12interpretorTest
{
    public class x12beg_tests
    {
        const string line1 = @"BEG*00*NE*INHALER WATCH       0F**20200424\";
        const string line2 = @"BEG*00*NE*PSG test split      00**20210407\";

        private readonly x12beg interpreter = new x12beg();
        
        [Theory]
        [InlineData(line1, "00", 1)]
        [InlineData(line2, "00", 1)]

        [InlineData(line1, "NE", 2)]
        [InlineData(line2, "NE", 2)]

        [InlineData(line1, "INHALER WATCH       0F", 3)]
        [InlineData(line2, "PSG test split      00", 3)]

        [InlineData(line1, null, 4)]
        [InlineData(line2, null, 4)]

        [InlineData(line1, "20200424", 5)]
        [InlineData(line2, "20210407", 5)]

        public void BEGTests(string line, string expected, int expectedField)
        {
            var results = interpreter.ProcessLine(line);

            Assert.Equal(line, results.OriginalValue);
            Assert.Equal("BEG", results.LineCode);
            Assert.Equal(expected, results.FieldResults[expectedField - 1].FileValue);
            Assert.Equal(expectedField, results.FieldResults[expectedField - 1].Field.Ordinal);
        }
    }
}
