using x12interpretor;
using Xunit;

namespace x12interpretorTest
{
    public class x12fileTest
    {
        private readonly Interpretor interpreter = new Interpretor();

        [Fact]
        public void testFile()
        {
           var data = interpreter.ProcessFile(fileData1);

            Assert.NotNull(data);
        }


        const string fileData1 = @"ISA*00*PSG       *00*PSG       *01*177667227      *ZZ*PSG            *200424*1131*U*00401*200000094*0*P*|\
GS*PO*177667227*PSG*20200424*1131*200000000*X*004010\
ST*850*0001\
BEG*00*NE*INHALER WATCH       0F**20200424\
REF*DP*020290*Department\
N1*BY*MCKESSON*91*712009\
PO1*1*6*EA***VC*1238856*N4*00173071920\
PO1*2*12*EA***VC*2055796*N4*00173086910\
PO1*3*36*EA***VC*1894260*N4*00173068224\
PO1*4*12*EA***VC*1773100*N4*00186037020\
PO1*5*24*EA***VC*3725116*N4*66993001968\
PO1*6*36*EA***VC*1826700*N4*00173068220\
PO1*7*24*EA***VC*1290774*N4*00597002402\
PO1*8*6*EA***VC*1978014*N4*00173052000\
PO1*9*12*EA***VC*3407947*N4*00173087310\
CTT*9\
SE*15*0001\
GE*1*200000000\
IEA*1*200000094\
";
    }
}
