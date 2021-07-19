
using x12interpretor.LineProcessors;
using Xunit;

namespace x12interpretorTest
{
    public class x12isa_tests
    {
        const string line1 = @"ISA*00*PSG       *00*PSG       *01*177667227      *ZZ*PSG            *200424*1131*U*00401*200000094*0*P*|\";
        const string line2 = @"ISA*00*PSG       *00*PSG       *01*177667227      *ZZ*PSG            *210407*1346*U*00401*201049312*0*P*|\";

        private readonly x12isa interpreter = new x12isa();

        [Theory]
        [InlineData(line1, "00", 1)]       
        [InlineData(line2, "00", 1)]

        [InlineData(line1, "PSG       ", 2)]
        [InlineData(line2, "PSG       ", 2)]

        [InlineData(line1, "00", 3)]
        [InlineData(line2, "00", 3)]

        [InlineData(line1, "PSG       ", 4)]
        [InlineData(line2, "PSG       ", 4)]

        [InlineData(line1, "01", 5)]
        [InlineData(line2, "01", 5)]

        [InlineData(line1, "177667227      ", 6)]
        [InlineData(line2, "177667227      ", 6)]

        [InlineData(line1, "ZZ", 7)]
        [InlineData(line2, "ZZ", 7)]

        [InlineData(line1, "PSG            ", 8)]
        [InlineData(line2, "PSG            ", 8)]

        [InlineData(line1, "200424", 9)]
        [InlineData(line2, "210407", 9)]

        [InlineData(line1, "1131", 10)]
        [InlineData(line2, "1346", 10)]

        [InlineData(line1, "U", 11)]
        [InlineData(line2, "U", 11)]

        [InlineData(line1, "00401", 12)]
        [InlineData(line2, "00401", 12)]

        [InlineData(line1, "200000094", 13)]
        [InlineData(line2, "201049312", 13)]

        [InlineData(line1, "0", 14)]
        [InlineData(line2, "0", 14)]

        [InlineData(line1, "P", 15)]
        [InlineData(line2, "P", 15)]

        [InlineData(line1, "|", 16)]
        [InlineData(line2, "|", 16)]

        public void ISATests(string line, string expected, int expectedField)
        {
            var results = interpreter.ProcessLine(line);

            Assert.Equal(line, results.OriginalValue);
            Assert.Equal("ISA", results.LineCode);
            Assert.Equal(expected, results.Fields[expectedField - 1].FileValue);
            Assert.Equal(expectedField, results.Fields[expectedField - 1].Field.Ordinal);
        }
    }
}
