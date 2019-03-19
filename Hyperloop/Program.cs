using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperloop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>();

            inputs.Add("0 34 34 34 0 0 0 0 0 85 85 85 85 85 85\n0 34 34 34 0 0 0 0 0 0 0 0 85 85 85\n0 34 34 0 45 45 45 0 84 84 84 84 0 85 85\n0 34 34 0 45 45 45 0 84 84 84 84 0 85 85\n0 0 0 0 0 45 45 0 84 0 84 84 0 0 0\n0 0 0 0 0 45 45 45 0 26 0 84 0 0 0\n0 0 0 0 0 45 45 45 0 26 0 0 0 0 0\n0 35 35 35 0 0 0 0 0 0 0 0 0 82 0\n35 35 35 35 0 0 0 25 25 0 82 82 82 82 0\n35 35 0 35 0 0 0 25 25 0 82 82 82 82 0\n35 0 67 0 0 33 0 25 25 0 82 82 82 82 0\n0 67 67 0 0 33 33 0 0 0 82 82 82 82 0\n0 67 67 0 0 0 33 33 33 33 0 0 0 0 0\n0 0 0 0 0 0 33 33 33 33 33 33 0 0 0\n0 0 0 0 0 0 33 33 33 33 33 33 0 0 0");
           


            Printer.printAllOutputs(inputs);
            Console.ReadLine();
        }
    }
}
