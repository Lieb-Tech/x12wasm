using System;
using x12interpretor;
using x12interpretor.LineProcessors;

namespace x12testor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            x12isa x12isa = new();
            string tst = @"ISA*00*PSG *00*PSG *01*177667227 *ZZ*PSG *200424*1131*U*00401*200000094*0*P*|\";
            var results = x12isa.ProcessLine(tst);

            tst = @"BEG*00*NE*INHALER WATCH 0F**20200424\";
            x12beg beg = new();
            results = beg.ProcessLine(tst);

            tst = @"REF*DP*020290*Department\";
            x12ref xref = new();
            results = xref.ProcessLine(tst);

            var z = results;
        }
    }
}
