using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvester
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>();

            inputs.Add("3 4 1 1");
            inputs.Add("2 5 2 1");
            inputs.Add("5 2 5 2");
            inputs.Add("23 12 1 12");


            Printer.printAllOutputs(inputs);
        }
    }
}
