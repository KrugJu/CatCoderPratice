using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trail
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>();

            inputs.Add("1 FFFR 4");
            inputs.Add("9 F 6 R 1 F 4 RFF 2 LFF 1 LFFFR 1 F 2 R 1 F 5");
            inputs.Add("14 L 1 FR 1 FFFFFL 1 FFFFL 1 F 12 L 1 F 12 L 1 F 12 L 1 FFFFL 1 FFFFFFFFR 1 FFFR 1 FFFL 1");
            inputs.Add("32 FFRFLFLFFRFRFLFF 3 R 1 FFLFRFRFLFFF 3 R 1 FFFFFF 3 L 1 FFFRFLFLFRFF 2 R 1 FFFRFLFLFRFF 3 R 1 FFFFFF 1 L 1 FFRFLFLFFRFRFLFF 3 R 1 FFLFRFRFFLFLFRFF 2 L 1 FFLFRFRFFLFLFRFF 3 R 1 FFRFLFLFFRFRFLFF 2 R 1 FFRFLFLFFRFRFLFF 2 L 1 FFFFFF 3 R 1 FFFRFLFLFRFF 5 R 1 FFLFRFRFLFFF 1 L 1 FFLFRFRFFLFLFRFF 2 R 1 FFRFLFLFFRFRFLFF 2 L 1");
            inputs.Add("10 FFLFRFRFFLFLFRFF 5 L 1 FFFRFLFLFRFF 4 L 1 FFLFRFRFFLFLFRFF 8 L 1 FFLFRFRFFLFLFRFF 4 L 1 FFFFFF 3 R 1");

            List<int> outputs = Processor.processAllInputs(inputs);



            foreach (int output in outputs)
            {
                Console.WriteLine(output);
            }


            Console.ReadKey();


        }
    }
}
