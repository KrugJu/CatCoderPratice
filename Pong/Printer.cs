using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public static class Printer
    {
        public static void printAllOutputs(List<string> inputs)
        {

            List<string> outputs = new List<string>();

            foreach (string input in inputs)
            {
                List<> splitValues = Splitter.   (input);

                string line = "";

                foreach (value in )
                {
                    line += value.ToString() + " ";
                }


                line = line.TrimEnd(' ');


                outputs.Add(line + "\n");
            }

            System.IO.File.WriteAllLines(@"C:\Users\Berger Elias\Downloads\Output\output.txt", outputs);
        }
    }
}
